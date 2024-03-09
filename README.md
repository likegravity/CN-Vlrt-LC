# LangChanger_ForChinaValorant
It is a Language changer for Valorant China servers.



이용방법입니다.
---------------------------------------------------
프로그램 다운로드 후 실행시, 텍스트 입력란에 자신의 중국 발로란트 설치 위치에 있는 Paks 폴더의 경로를 적으시면 됩니다.
예) C:\Program Files (x86)\Tencent Games\VALORANT\live\ShooterGame\Content\Paks

중국발로란트 실행 후 몇초 안에 Change버튼을 누르시면 됩니다.
이는 발로란트를 매번 실행할때마다 진행해야합니다.

구버전 대비 변경사항
---------------------------------------------------
1.UI추가를 포함한 기능으로 새로 만들었습니다.

![ui](https://github.com/likegravity/LangChanger_ForChinaValorant/assets/110320707/a896ad5f-4080-4a13-8511-769a420bfc97)

2.이 프로그램은 중국서버에서의 언어변경을 지원합니다. 만, 영어만을 한정적으로 지원합니다.
이유는 다음과 같습니다.
  1. 보이스 출력시 문제가 있습니다.
  2. 일부 컴퓨터에서 한글이 아닌 영어로(?) 출력되는 문제가 발견되었습니다.

     ~~이유를 예상해보자면,
     중국 언어파일도 영어언어파일을 레퍼런스로 한거같은데,
     그래서 한국 언어파일과 이름 자체가 통일이 되지 않은 경우가 많아서 그런 것 같기도합니다.
     한국언어파일도 영어 언어파일을 통해 만들었을텐데, 왜 작동 안하는지는 이유를 모르겠습니다.~~

3.각종 오류가 줄어들었습니다.
  사용자가 설정해야 할 것을 최소한으로 만들어 간편하게 작동하도록 작성하였습니다.

오류해결법
---------------
1. "중국발로란트 폴더의 경로를 설정해주세요."
   말 그대로 폴더의 경로가 입력되지 않은 상태입니다.
   경로를 입력하세요.

2. "중국발로란트 파일의 경로설정이 잘못되었습니다."
   이 또한 폴더의 경로가 Paks경로로 지정되지 않은 상태를 의미합니다.
   경로를 올바르게 작성하세요. 또한, 공백이나 오탈자가 없는지 확인하세요.

3. "Paks"폴더에 영어pak 파일이 없거나 이름이 잘못됨."
   이는 프로그램 다운로드 시 폴더에 있는 "Paks"폴더가 존재하지 않거나, 폴더 안에 있는 4개의 Pak 파일들이 없거나 손상된 경우입니다.
   프로그램 삭제 후 재설치 시 해결되는 문제입니다.

4. 게임에서 크래시가 나는 경우
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
   
   _주의:절대로 파일의 이름의 시작이 en_us 가 아니라고 해서 파일의 이름을 강제로 변경하지 마십시오. 냉장고를 에어컨이라고 부른다 해서 냉장고가 에어컨이 되는게 아닙니다._
   -----

개발용도로 참고하고싶은 개발자라면
------------------
만약 자신이 C# 시작한지 5일도 안된 사람의 코드를 참고하고싶다면,
다음과 같은 Nuget package 들이 필요합니다.
   
"소스를 업데이트 할때 필요한 Nuget 패키지들"
   
1. Guna.UI2.WinForms
2. Costura.Fody




