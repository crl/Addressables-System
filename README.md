# Addressables-System
研究unity 的最新打包工具,并整合 多场景引用,及与 amf 序列化的相关工具进行 引用 关联

AddressableAssetsWindow: Window/Asset Management/Addressable Assets

AddressableAssetsSettingsGroupEditor: 为全局设置面板

感觉前面绕一大圈,只为了让其它开发者可以重写,或编译器与运行时的区别, 跟我以前的AssetManager差不多,只是看得很绕


核心点:(把这部份重写掉就可以)

BuildContent.BundleBuildContent()
1. AssetBundleBuild 主要为要整合在一起的单个包( 里面可以包含多个文件)
2. 区分场景与普通资源
2. 在此处可以做依赖收集 (一般我会做引用数,当引用数大于1时,会把它创建为AssetBundleBuild,重走第一步)

ContentPipeline.BuildAssetBundles() 更细的底层如果打包 收集信息
1. BuildTasksRunner.Run();
2. foreach IBuildTask.Run(); 一堆的Task,有一个不通过 就算不通过
  1. SwitchToBuildPlatform   是否要切换平台
  2. RebuildSpriteAtlasCache 调用了图集打包
  3. WriteSerializedFiles
  4. ArchiveAndCompressBundles
  ...