namespace Code
{
    public class BaiHat
    {
        private string id;
        private string ten;
        private string tenCaSi;
        private int doDai;
        private string tenNhacSi;
        public BaiHat()
        {

        }

        public BaiHat(string id, string ten, string tenCaSi, int doDai, string tenNhacSi)
        {
            this.id = id;
            this.ten = ten;
            this.tenCaSi = tenCaSi;
            this.doDai = doDai;
            this.tenNhacSi = tenNhacSi;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TenCaSi { get => tenCaSi; set => tenCaSi = value; }
        public int DoDai { get => doDai; set => doDai = value; }
        public string TenNhacSi { get => tenNhacSi; set => tenNhacSi = value; }
    }
}
