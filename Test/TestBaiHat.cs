using Code;

namespace Test
{
    internal class TestBaiHat
    {
        BaiHatService service;
        [SetUp]
        public void Setup()
        {
            service = new();
        }
        [Test]
        public void DeleteBaiHat()
        {
            Assert.IsTrue(service.DeleteBaiHat("1"));
        }
        [Test]
        public void DeleteBaiHatWithInvalidId()
        {
            Assert.IsFalse(service.DeleteBaiHat("0"));
        }
        [Test]
        public void DeleteBaiHatWithNullId()
        {
            Assert.IsFalse(service.DeleteBaiHat(null));
        }
        [Test]
        public void DeleteBaiHatWithEmptyId()
        {
            Assert.IsFalse(service.DeleteBaiHat(""));
        }
        [Test]
        public void DeleteBaiHatWithWhiteSpaceId()
        {
            Assert.IsFalse(service.DeleteBaiHat(" "));
        }
        [Test]
        public void AddBaiHat()
        {
            BaiHat baiHat = new BaiHat
            {
                Id = "4",
                Ten = "Test",
                TenCaSi = "Test",
                DoDai = 10,
                TenNhacSi = "Test"
            };
            Assert.IsTrue(service.AddBaiHat(baiHat));
        }
        [Test]
        public void AddBaiHatWithDuplicateId()
        {
            BaiHat baiHat = new BaiHat
            {
                Id = "1",
                Ten = "Test",
                TenCaSi = "Test",
                DoDai = 10,
                TenNhacSi = "Test"
            };
            Assert.IsFalse(service.AddBaiHat(baiHat));
        }
        [Test]
        public void AddBaiHatWithInvalidDoDai()
        {
            BaiHat baiHat = new BaiHat
            {
                Id = "4",
                Ten = "Test",
                TenCaSi = "Test",
                DoDai = 0,
                TenNhacSi = "Test"
            };
            Assert.IsFalse(service.AddBaiHat(baiHat));
        }
        [Test]
        public void AddBaiHatWithNegativeDoDai()
        {
            BaiHat baiHat = new BaiHat
            {
                Id = "4",
                Ten = "Test",
                TenCaSi = "Test",
                DoDai = -1,
                TenNhacSi = "Test"
            };
            Assert.IsFalse(service.AddBaiHat(baiHat));
        }
        [Test]
        public void AddBaiHatWithNullId()
        {
            BaiHat baiHat = new BaiHat
            {
                Id = null,
                Ten = "Test",
                TenCaSi = "Test",
                DoDai = 10,
                TenNhacSi = "Test"
            };
            Assert.IsFalse(service.AddBaiHat(baiHat));
        }
    }
}
