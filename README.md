

# AR-MARIMBA
증강현실기반 마림바 유사악기 (Augmented Reality based Marimba like Instrument)
<br><br>

## Screen Shot
|시작화면|안내문|재생모습|
|--|--|--|
|![image](https://user-images.githubusercontent.com/37680108/102649100-f45ed200-41ab-11eb-8f19-345845d987e3.png)|![image](https://user-images.githubusercontent.com/37680108/102649011-d6916d00-41ab-11eb-8b95-ad31b81287b4.png)|![image](https://user-images.githubusercontent.com/37680108/102649034-dc874e00-41ab-11eb-878f-7e3fec95b6b6.png)|
<br><br>

## Description
![Unity](https://img.shields.io/badge/Unity-2019.4.13f1-blue) ![Vuforia](https://img.shields.io/badge/Vuforia-8.1.12-green) ![C#](https://img.shields.io/badge/C%23-Rider-orange)

![image](https://user-images.githubusercontent.com/37680108/116304556-a69f4980-a7dd-11eb-97f2-a58446f1a67e.png)
_Flow Chart_

`Virtual Button`, `3D text`, `Particle System`, `Rotating Animation`, `Change Scene`

<br><br>

## Directory hierarchy 
```bash
AR-MARIMBA
├── image_target.jpg # 본 프로젝트에서 image target으로 사용한 이미지
├── Assets
│   ├── AurynSky # 보석 object
│   │   └── Gems\ Ultimate\ Pack
│   │       ├── Materials
│   │       ├── Models
│   │       ├── Prefabs
│   │       ├── Scenes
│   │       └── Scripts
│   ├── Editor
│   │   └── Vuforia
│   │       ├── CylinderTargetTextures
│   │       │   └── VuforiaMars_Images
│   │       ├── ForPrint
│   │       │   ├── CylinderTarget
│   │       │   ├── ImageTargets
│   │       │   └── MultiTarget
│   │       └── ImageTargetTextures # imageTarget texture 저장
│   │           ├── cd2
│   │           └── paper
│   ├── Resources # 음원, 버튼, 배경, 색상 리소스 저장
│   ├── Scenes # 총 2개의 scene 존재 (시작화면, 플레이화면)
│   ├── Scripts # object 에서 사용되는 스크립트 저장
│   └── StreamingAssets
│       └── Vuforia # imageTarget asset 저장
├── Library
│   ├── ... # 라이브러리, 기타 생략
```
