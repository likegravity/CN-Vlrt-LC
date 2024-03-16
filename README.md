

# [다운로드링크](https://github.com/likegravity/LC_ForChinaValorant/releases/download/C%23/Language.changer.zip)


# LC_ForChinaValorant
# Chinese to English(no voice provision)
# 중국어에서 영어로 바꿔주는 프로그램입니다.(근데 보이스 안들림)
It is a Language changer for Valorant China servers.

***디펜더 끄세요. 바이러스 탐지되는데, 바이러스아닙니다. 소스코드도 다 공개해두었어요. 디펜더 열어서 허용 눌러주세요. 프로그램 삭제되기전에.***


이용방법입니다.
---------------------------------------------------
프로그램 다운로드 후 실행시, 텍스트 입력란에 자신의 중국 발로란트 설치 위치에 있는 Paks 폴더의 경로를 적으시면 됩니다.
예) C:\Program Files (x86)\Tencent Games\VALORANT\live\ShooterGame\Content\Paks

실행 후, 오류리스트에 오류가 나오지 않는다면, 그대로 중국 발로란트를 실행하시면 됩니다!
실행 후 자동으로 꺼집니다. 이 얼마나 간편한가!

# 주의!!!!!!!!!!!!!!!!!
LC를 이용하여 언어를 영어로 변경할시에, 보이스출력이 되지 않습니다.
그런데 세이지목소리는 가끔 중국어로 나옵니다<--~~왜이런지 아직도 모르겠다니까 나는??~~



오류해결법
---------------
1. "중국발로란트 폴더의 경로를 설정해주세요."
   말 그대로 폴더의 경로가 입력되지 않은 상태입니다.
   **경로를 입력하세요.**

3. "중국발로란트 파일의 경로설정이 잘못되었습니다."
   **이 또한 폴더의 경로가 Paks경로로 지정되지 않은 상태를 의미합니다.
   경로를 올바르게 작성하세요. 또한, 공백이나 오탈자가 없는지 확인하세요.**

4. "Paks"폴더에 영어pak 파일이 없거나 이름이 잘못됨."
   ~~이는 프로그램 다운로드 시 폴더에 있는 "Paks"폴더가 존재하지 않거나, 폴더 안에 있는 4개의 Pak 파일들이 없거나 손상된 경우입니다.
   프로그램 삭제 후 재설치 시 해결되는 문제입니다.~~ **제가 pak파일 업데이트를 지원하지 않기때문에, 아래 4번오류를 따라서, pak파일을 추출한 후 직접 덮어씌워주시기 바랍니다.**

5. 게임에서 크래시가 나는 경우
   이는 보통 발로란트의 업데이트가 진행 되었을때, 프로그램 안에 있는 "Paks"폴더 안 pak파일이 구버전인 경우입니다.
   1. 제작자의 업데이트를 손가락이나 빨며 기다리시거나,
   2. 직접 en_US paks 파일을 구해서 "Paks"폴더의 파일을 덮어 씌우면 해결됩니다.

   2번의 해결방법을 실행하려 하실 경우, 필요한 파일들의 기본 경로를 참고하시면 됩니다.
   
   아래는 기본경로입니다.

   C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks\en_US_Audio-WindowsClient.pak
   C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks\en_US_Audio-WindowsClient.sig
   C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks\en_US_Text-WindowsClient.pak
   C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks\en_US_Text-WindowsClient.sig

   만약 파일의 이름의 시작이 en_US 가 아닌 경우, 발로란트의 언어를 영어로 변경 후 진행하시면 됩니다.

*********************************************************************************
  ***주의:***
  ***절대로 파일의 이름의 시작이 en_us 가 아니라고 해서 파일의 이름을 강제로 변경하지 마십시오.***
  
  ***냉장고를 에어컨이라고 부른다 해서 냉장고가 에어컨이 되는게 아닙니다.***
*********************************************************************************

개발용도로 참고하고싶은 개발자라면
------------------
만약 자신이 C# 시작한지 5일도 안된 사람의 코드를 참고하고싶다면,
다음과 같은 Nuget package 들이 필요합니다.
   
"소스를 업데이트 할때 필요한 Nuget 패키지들"
   
1. Guna.UI2.WinForms
2. Costura.Fody




