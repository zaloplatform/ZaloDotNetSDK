using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class TargetBroadcastCities
    {
        private string value;

        private TargetBroadcastCities(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static TargetBroadcastCities DONG_THAP = new TargetBroadcastCities("0");
        public static TargetBroadcastCities BINH_PHUOC = new TargetBroadcastCities("1");
        public static TargetBroadcastCities NINH_BINH = new TargetBroadcastCities("2");
        public static TargetBroadcastCities BAC_LIEU = new TargetBroadcastCities("3");
        public static TargetBroadcastCities HO_CHI_MINH = new TargetBroadcastCities("4");
        public static TargetBroadcastCities VINH_LONG = new TargetBroadcastCities("5");
        public static TargetBroadcastCities LAM_DONG = new TargetBroadcastCities("6");
        public static TargetBroadcastCities YEN_BAI = new TargetBroadcastCities("7");
        public static TargetBroadcastCities HA_NAM = new TargetBroadcastCities("8");
        public static TargetBroadcastCities HA_NOI = new TargetBroadcastCities("9");
        public static TargetBroadcastCities HAI_DUONG = new TargetBroadcastCities("10");
        public static TargetBroadcastCities HAU_GIANG = new TargetBroadcastCities("11");
        public static TargetBroadcastCities AN_GIANG = new TargetBroadcastCities("12");
        public static TargetBroadcastCities TRA_VINH = new TargetBroadcastCities("13");
        public static TargetBroadcastCities TIEN_GIANG = new TargetBroadcastCities("14");
        public static TargetBroadcastCities TAY_NINH = new TargetBroadcastCities("15");
        public static TargetBroadcastCities DONG_NAI = new TargetBroadcastCities("16");
        public static TargetBroadcastCities DAK_LAK = new TargetBroadcastCities("17");
        public static TargetBroadcastCities BINH_DINH = new TargetBroadcastCities("18");
        public static TargetBroadcastCities KON_TUM = new TargetBroadcastCities("19");
        public static TargetBroadcastCities DA_NANG = new TargetBroadcastCities("20");
        public static TargetBroadcastCities BAC_GIANG = new TargetBroadcastCities("21");
        public static TargetBroadcastCities BAC_KAN = new TargetBroadcastCities("22");
        public static TargetBroadcastCities DIEN_BIEN = new TargetBroadcastCities("23");
        public static TargetBroadcastCities HOA_BINH = new TargetBroadcastCities("24");
        public static TargetBroadcastCities THAI_BINH = new TargetBroadcastCities("25");
        public static TargetBroadcastCities VINH_PHUC = new TargetBroadcastCities("26");
        public static TargetBroadcastCities HA_GIANG = new TargetBroadcastCities("27");
        public static TargetBroadcastCities KIEN_GIANG = new TargetBroadcastCities("28");
        public static TargetBroadcastCities BINH_DUONG = new TargetBroadcastCities("29");
        public static TargetBroadcastCities BINH_THUAN = new TargetBroadcastCities("30");
        public static TargetBroadcastCities DAK_NONG = new TargetBroadcastCities("31");
        public static TargetBroadcastCities KHANH_HOA = new TargetBroadcastCities("32");
        public static TargetBroadcastCities GIA_LAI = new TargetBroadcastCities("33");
        public static TargetBroadcastCities QUANG_NAM = new TargetBroadcastCities("34");
        public static TargetBroadcastCities QUANG_TRI = new TargetBroadcastCities("35");
        public static TargetBroadcastCities HA_TINH = new TargetBroadcastCities("36");
        public static TargetBroadcastCities HUNG_YEN = new TargetBroadcastCities("37");
        public static TargetBroadcastCities QUANG_NINH = new TargetBroadcastCities("38");
        public static TargetBroadcastCities THANH_HOA = new TargetBroadcastCities("39");
        public static TargetBroadcastCities PHU_THO = new TargetBroadcastCities("40");
        public static TargetBroadcastCities LAI_CHAU = new TargetBroadcastCities("41");
        public static TargetBroadcastCities THAI_NGUYEN = new TargetBroadcastCities("42");
        public static TargetBroadcastCities CAO_BANG = new TargetBroadcastCities("43");
        public static TargetBroadcastCities CA_MAU = new TargetBroadcastCities("44");
        public static TargetBroadcastCities CAN_THO = new TargetBroadcastCities("45");
        public static TargetBroadcastCities SOC_TRANG = new TargetBroadcastCities("46");
        public static TargetBroadcastCities BEN_TRE = new TargetBroadcastCities("47");
        public static TargetBroadcastCities LONG_AN = new TargetBroadcastCities("48");
        public static TargetBroadcastCities BA_RIA_VUNG_TAU = new TargetBroadcastCities("49");
        public static TargetBroadcastCities NINH_THUAN = new TargetBroadcastCities("50");
        public static TargetBroadcastCities PHU_YEN = new TargetBroadcastCities("51");
        public static TargetBroadcastCities QUANG_NGAI = new TargetBroadcastCities("52");
        public static TargetBroadcastCities THUA_THIEN_HUE = new TargetBroadcastCities("53");
        public static TargetBroadcastCities QUANG_BINH = new TargetBroadcastCities("54");
        public static TargetBroadcastCities NGHE_AN = new TargetBroadcastCities("55");
        public static TargetBroadcastCities NAM_DINH = new TargetBroadcastCities("56");
        public static TargetBroadcastCities HAI_PHONG = new TargetBroadcastCities("57");
        public static TargetBroadcastCities LANG_SON = new TargetBroadcastCities("58");
        public static TargetBroadcastCities LAO_CAI = new TargetBroadcastCities("59");
        public static TargetBroadcastCities SON_LA = new TargetBroadcastCities("60");
        public static TargetBroadcastCities BAC_NINH = new TargetBroadcastCities("61");
        public static TargetBroadcastCities TUYEN_QUANG = new TargetBroadcastCities("62");
        public static TargetBroadcastCities OUT_SIDE_VIETNAM = new TargetBroadcastCities("63");
    }
}
