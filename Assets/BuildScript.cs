using UnityEditor;

public class BuildScript
{
    [MenuItem("Build/Build APK")]
    public static void BuildAndroid()
    {
        string[] scenes = { "Assets/Scenes/MainScene.unity" };  // ������� ���� �����
        string buildPath = @"D:\Builds\myapp.apk";  // ���� ��� ���������� APK
        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.Android, BuildOptions.None);
    }
}
