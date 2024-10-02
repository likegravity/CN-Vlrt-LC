
### [DownloadLink](https://github.com/likegravity/LC_ForChinaValorant/releases/download/C%23/Language.changer.zip)


LC_ForChinaValorant is a language changer for the China Valorant server. 
It supports translation from Chinese to English, but does not support in-game sounds (such as character voices).
It is a Language changer for Valorant China servers.

Please disable Windows Defender. It detects a virus, but this is not a virus. The source code is fully open and available. Please go to Defender and allow the program before it gets deleted.

Here’s how to use it:
After downloading and running the program, enter the path to the `Paks` folder where your Chinese Valorant is installed into the text field. For example: 
```plaintext
C:\Program Files (x86)\Tencent Games\VALORANT\live\ShooterGame\Content\Paks
```

Once you run it, if there are no errors in the error list, you can proceed to run Chinese Valorant. The program will close automatically after that. How convenient!

**Important Notice**  
If you use LC to change the language to English, voice output will not work.
However, sometimes Sage's voice randomly comes out in Chinese — I still don’t know why!

# Error Resolution:

1. **"Please set the path to the Chinese Valorant folder."**  
   This means the folder path hasn’t been entered. 
   Please input the path.

2. **"The path to the Chinese Valorant files is incorrect."**  
   This indicates the folder path has not been correctly set to the `Paks` folder. 
   Please ensure the path is correct, and check for any spaces or typos.

3. **"The English pak file is missing or incorrectly named in the `Paks` folder."**  
   This happens when the `Paks` folder doesn’t exist or the four Pak files inside are missing or corrupted. 
   You can solve this issue by reinstalling the program. 
   Since I don’t support Pak file updates, you’ll need to extract and replace the pak files manually following error 4.

4. **Game crashes**  
   If your game crashes, it usually happens because Valorant was updated, and the pak files inside the `Paks` folder are outdated. 
   You can either wait for the developer’s update or find the en_US pak files yourself and replace them in the `Paks` folder.

If you choose the second option, here are the default paths for the necessary files:

```plaintext
C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks\en_US_Audio-WindowsClient.pak
C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks\en_US_Audio-WindowsClient.sig
C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks\en_US_Text-WindowsClient.pak
C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks\en_US_Text-WindowsClient.sig
```

If the filenames don’t start with "en_US", switch your Valorant language to English and proceed.

**Warning**: Do not manually rename the files if they don’t start with "en_US". 
Renaming the file won’t change its functionality, just like calling a fridge an air conditioner doesn’t make it one.

# For Developers Interested in This Code:  
If you’re looking to reference code from a developer who’s been using C# for less than five days, you’ll need the following NuGet packages.

**"NuGet packages required for source code updates"**:
- Guna.UI2.WinForms
- Costura.Fody
- buy me coffee 100usd

