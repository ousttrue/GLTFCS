using System;
using System.IO;
using SegmentTree;
using SegmentTree.Json;
using Xunit;

namespace GLTFCS.Tests
{
    public class GLTFTest
    {
        [Theory]
        [InlineData("Cube/glTF/Cube.gltf")]
        public void TestLoader(string path)
        {
            var sampleRoot = "../../../../../glTF-Sample-Models/2.0";
            var fullPath = Path.Combine(sampleRoot, path);
            Assert.True(File.Exists(fullPath));

            var bytes = File.ReadAllBytes(fullPath);

            var utf8 = new Utf8StringTmp(bytes).ToString();

            var p = new JsonParser();
            var parsed = p.Parse(bytes);

            Assert.Equal(JsonValueType.Object, parsed.ValueType);
        }
    }
}
