# com.kibalab.udonsharpwatcher

| 🇺🇸 [English](./README.md) | 🇰🇷 [한국어](./README.ko.md) | 🇯🇵 [日本語](./README.ja.md) |

UdonSharpWatcher は、`UdonSharpBehaviour` スクリプトを追加・更新した際に対応する `UdonSharpProgramAsset` を自動生成し、プロジェクトと同期します。

## 機能
- `UdonSharpBehaviour` を継承した `.cs` ファイルを検知して処理を行います。
- Unity パッケージやキャッシュフォルダを無視することで重複生成を防止します。
- 必要な `.asset` を作成・インポートするため、VRChat へ手作業でアセットを用意する必要がありません。

## インストール
1. [https://vpm.kiba.red](https://vpm.kiba.red) から `com.kibalab.udonsharpwatcher` パッケージの VPM リスト URL を取得します。
2. VRChat Community Client に `vcc://vpm/addRepo?url=<listing-url>` でリポジトリを追加します。
3. VPM で `com.kibalab.udonsharpwatcher` を検索してインストールし、`UDONSHARP` スクリプト定義シンボルと VRC SDK (`VRC.SDK3`, `UdonSharp`) の依存関係があることを確認してください。
