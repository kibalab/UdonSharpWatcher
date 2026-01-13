# com.kibalab.udonsharpwatcher

| 🇺🇸 [English](./README.md) | 🇰🇷 [한국어](./README.ko.md) | 🇯🇵 [日本語](./README.ja.md) |

UdonSharpWatcher는 `UdonSharpBehaviour`를 수정하거나 추가할 때 관련 `UdonSharpProgramAsset`을 자동으로 생성하여 Unity 프로젝트와 일치시켜 줍니다.

## 주요 기능
- `UdonSharpBehaviour`를 상속한 `.cs` 스크립트의 추가/변경을 감지합니다.
- Unity 패키지 또는 캐시 폴더를 건너뛰어 중복된 에셋 생성을 방지합니다.
- `.asset`을 생성하고 임포트하여 VRChat에 수동으로 에셋을 만들지 않아도 됩니다.

## 설치
1. [https://vpm.kiba.red](https://vpm.kiba.red)에서 `com.kibalab.udonsharpwatcher` 패키지의 VPM listing URL을 확인합니다.
2. VRChat Community Client에 `vcc://vpm/addRepo?url=<listing-url>`로 listing을 추가합니다.
3. VPM에서 `com.kibalab.udonsharpwatcher`를 찾아 설치하고, `UDONSHARP` 스크립팅 심볼과 VRC SDK(`VRC.SDK3`, `UdonSharp`)를 포함했는지 확인합니다.