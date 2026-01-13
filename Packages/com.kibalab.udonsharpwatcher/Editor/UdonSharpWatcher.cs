#if UNITY_EDITOR && UDONSHARP
using System;
using System.IO;
using System.Runtime.CompilerServices;
using UdonSharp;
using UnityEditor;
using UnityEngine;

namespace K13A.Editor
{
    public sealed class UdonSharpWatcher : AssetPostprocessor
    {
        private static void OnPostprocessAllAssets(
            string[] importedAssets,
            string[] deletedAssets,
            string[] movedAssets,
            string[] movedFromAssetPaths)
        {
            foreach (var assetPath in importedAssets)
            {
                if (!assetPath.EndsWith(".cs", StringComparison.Ordinal))
                {
                    continue;
                }

                if (assetPath.Contains("Packages/", StringComparison.Ordinal))
                {
                    continue;
                }

                var monoScript = AssetDatabase.LoadAssetAtPath<MonoScript>(assetPath);
                if (monoScript == null)
                {
                    continue;
                }

                var scriptType = monoScript.GetClass();
                if (
                    scriptType == null ||
                    scriptType.IsAbstract ||
                    scriptType.IsGenericType ||
                    scriptType.IsGenericTypeDefinition ||
                    !typeof(UdonSharpBehaviour).IsAssignableFrom(scriptType) ||
                    scriptType.IsDefined(typeof(CompilerGeneratedAttribute), true)
                )
                {
                    continue;
                }

                var programAssetPath = Path.ChangeExtension(assetPath, ".asset");
                if (
                    File.Exists(programAssetPath) ||
                    AssetDatabase.LoadAssetAtPath<UdonSharpProgramAsset>(programAssetPath) != null
                )
                {
                    continue;
                }

                var programAsset = ScriptableObject.CreateInstance<UdonSharpProgramAsset>();
                programAsset.name = Path.GetFileNameWithoutExtension(programAssetPath);
                programAsset.sourceCsScript = monoScript;

                AssetDatabase.CreateAsset(programAsset, programAssetPath);
                AssetDatabase.ImportAsset(programAssetPath);

                Debug.Log($"[U#Watcher] '{programAssetPath}' Generated for '{assetPath}'");
            }
        }
    }
}
#endif // UNITY_EDITOR && UDONSHARP