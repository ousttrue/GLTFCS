using System;
using System.IO;
using Xunit;

namespace GLTFRW.Tests
{
    public class GLTFTest
    {
        [Theory]
        [InlineData("Cube/glTF/Cube.gltf")]
        public void TestLoader(string path)
        {
            var sample_root = "../../../../../glTF-Sample-Models/2.0";
            Assert.True(File.Exists(Path.Combine(sample_root, path)));
        }
    }
}
