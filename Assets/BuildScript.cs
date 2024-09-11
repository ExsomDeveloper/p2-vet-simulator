using UnityEditor;

public class BuildScript
{
    [MenuItem("Build/Build APK")]
    public static void BuildAndroid()
    {
        string[] scenes = { "Assets/Scenes/MainScene.unity" };  // Укажите свои сцены
        string buildPath = @"D:\Builds\myapp.apk";  // Путь для сохранения APK
        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.Android, BuildOptions.None);
    }
}
