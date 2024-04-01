namespace Code
{
    public class BaiHatService
    {
        List<BaiHat> lstBaiHat;
        public BaiHatService()
        {
            lstBaiHat = new List<BaiHat>()
            {
                new BaiHat("1", "Anh muon em song sao", "Bich Phuong", 240, "Bich Phuong"),
                new BaiHat("2", "Co gai m52", "Huong Tram", 240, "Huong Tram"),
                new BaiHat("3", "Chung ta cua tuong lai", "Son Tung MTP", 500, "Son Tung MTP"),
            };
        }
        public bool AddBaiHat(BaiHat baiHat)
        {
            if (baiHat.Id == null || baiHat.Id == "" || baiHat.Id == " " || baiHat.Id == "0")
            {
                return false;
            }
            else if (lstBaiHat.Any(x => x.Id == baiHat.Id))
            {
                return false;
            }
            else if (baiHat.DoDai <= 0)
            {
                return false;
            }
            lstBaiHat.Add(baiHat);
            return true;
        }
        public bool DeleteBaiHat(string id)
        {
            var baiHat = lstBaiHat.FirstOrDefault(x => x.Id == id);
            if (baiHat == null)
            {
                return false;
            }
            lstBaiHat.Remove(baiHat);
            return true;
        }
    }
}
