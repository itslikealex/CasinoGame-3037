using System.Drawing;

namespace Casino
{
    public class Card
    {
        public Image GetImage { get; set; }
        public int cardNum { get; set; }
        public string imageName { get; set; }
        //public Image Image1 { set; get;}
        public int CardFace { get; set; }
        public int CardSuit { get; set; }
        public string CardName { get; set; }
        public void GetCardName()
        {
            string first;
            string second;
            switch (this.CardSuit)
            {
                case 0:
                    second = "Spades";
                    break;
                case 1:
                    second = "Clubs";
                    break;
                case 2:
                    second = "Hearts";
                    break;
                default:
                    second = "Diamonds";
                    break;
            }
            switch (this.CardFace)
            {
                case 0:
                    first = "Ace";
                    break;
                case 1:
                    first = "Two";
                    break;
                case 2:
                    first = "Three";
                    break;
                case 3:
                    first = "Four";
                    break;
                case 4:
                    first = "Five";
                    break;
                case 5:
                    first = "Six";
                    break;
                case 6:
                    first = "Seven";
                    break;
                case 7:
                    first = "Eight";
                    break;
                case 8:
                    first = "Nine";
                    break;
                case 9:
                    first = "Ten";
                    break;
                case 10:
                    first = "Jack";
                    break;
                case 11:
                    first = "Queen";
                    break;
                default:
                    first = "King";
                    break;
            }
            this.CardName = first + " of " + second;
        }
        public Card(int cardNumber)
        {
            cardNum = cardNumber;
            this.CardSuit = cardNumber / 13;
            this.CardFace = cardNumber % 13;
            //this.Image1=imageArray[cardNumber]
            GetCardName();
            //GetImage();
        }
        /*
        private void GetImage()
        {
            string first;
            string second;
            string imageName;
            switch (this.CardSuit)
            {
                case 0:
                    second = "spade";
                    break;
                case 1:
                    second = "club";
                    break;
                case 2:
                    second = "heart";
                    break;
                default:
                    second = "diamond";
                    break;
            }
            switch (this.CardFace)
            {
                case 0:
                    first = "ace";
                    break;
                case 1:
                    first = "2";
                    break;
                case 2:
                    first = "3";
                    break;
                case 3:
                    first = "4";
                    break;
                case 4:
                    first = "5";
                    break;
                case 5:
                    first = "6";
                    break;
                case 6:
                    first = "7";
                    break;
                case 7:
                    first = "8";
                    break;
                case 8:
                    first = "9";
                    break;
                case 9:
                    first = "10";
                    break;
                case 10:
                    first = "jack";
                    break;
                case 11:
                    first = "queen";
                    break;
                default:
                    first = "king";
                    break;
            }
            imageName = first + "_" + second + ".png";
        }
        */

        public void LoadImage()
        {
            switch (cardNum)
            {
                case (0):
                    GetImage = Casino.Properties.Resources.ace_spade;
                    break;
                case (1):
                    GetImage = Casino.Properties.Resources._2_spade;
                    break;
                case (2):
                    GetImage = Casino.Properties.Resources._3_spade;
                    break;
                case (3):
                    GetImage = Casino.Properties.Resources._4_spade;
                    break;
                case (4):
                    GetImage = Casino.Properties.Resources._5_spade;
                    break;
                case (5):
                    GetImage = Casino.Properties.Resources._6_spade;
                    break;
                case (6):
                    GetImage = Casino.Properties.Resources._7_spade;
                    break;
                case (7):
                    GetImage = Casino.Properties.Resources._8_spade;
                    break;
                case (8):
                    GetImage = Casino.Properties.Resources._9_spade;
                    break;
                case (9):
                    GetImage = Casino.Properties.Resources._10_spade;
                    break;
                case (10):
                    GetImage = Casino.Properties.Resources.jack_spade;
                    break;
                case (11):
                    GetImage = Casino.Properties.Resources.queen_spade;
                    break;
                case (12):
                    GetImage = Casino.Properties.Resources.king_spade;
                    break;
                case (13):
                    GetImage = Casino.Properties.Resources.ace_club;
                    break;
                case (14):
                    GetImage = Casino.Properties.Resources._2_club;
                    break;
                case (15):
                    GetImage = Casino.Properties.Resources._3_club;
                    break;
                case (16):
                    GetImage = Casino.Properties.Resources._4_club;
                    break;
                case (17):
                    GetImage = Casino.Properties.Resources._5_club;
                    break;
                case (18):
                    GetImage = Casino.Properties.Resources._6_club;
                    break;
                case (19):
                    GetImage = Casino.Properties.Resources._7_club;
                    break;
                case (20):
                    GetImage = Casino.Properties.Resources._8_club;
                    break;
                case (21):
                    GetImage = Casino.Properties.Resources._9_club;
                    break;
                case (22):
                    GetImage = Casino.Properties.Resources._10_club;
                    break;
                case (23):
                    GetImage = Casino.Properties.Resources.jack_club;
                    break;
                case (24):
                    GetImage = Casino.Properties.Resources.queen_club;
                    break;
                case (25):
                    GetImage = Casino.Properties.Resources.king_club;
                    break;
                case (26):
                    GetImage = Casino.Properties.Resources.ace_heart;
                    break;
                case (27):
                    GetImage = Casino.Properties.Resources._2_heart;
                    break;
                case (28):
                    GetImage = Casino.Properties.Resources._3_heart;
                    break;
                case (29):
                    GetImage = Casino.Properties.Resources._4_heart;
                    break;
                case (30):
                    GetImage = Casino.Properties.Resources._5_heart;
                    break;
                case (31):
                    GetImage = Casino.Properties.Resources._6_heart;
                    break;
                case (32):
                    GetImage = Casino.Properties.Resources._7_heart;
                    break;
                case (33):
                    GetImage = Casino.Properties.Resources._8_heart;
                    break;
                case (34):
                    GetImage = Casino.Properties.Resources._9_heart;
                    break;
                case (35):
                    GetImage = Casino.Properties.Resources._10_heart;
                    break;
                case (36):
                    GetImage = Casino.Properties.Resources.jack_heart;
                    break;
                case (37):
                    GetImage = Casino.Properties.Resources.queen_heart;
                    break;
                case (38):
                    GetImage = Casino.Properties.Resources.king_heart;
                    break;
                case (39):
                    GetImage = Casino.Properties.Resources.ace_diamond;
                    break;
                case (40):
                    GetImage = Casino.Properties.Resources._2_diamond;
                    break;
                case (41):
                    GetImage = Casino.Properties.Resources._3_diamond;
                    break;
                case (42):
                    GetImage = Casino.Properties.Resources._4_diamond;
                    break;
                case (43):
                    GetImage = Casino.Properties.Resources._5_diamond;
                    break;
                case (44):
                    GetImage = Casino.Properties.Resources._6_diamond;
                    break;
                case (45):
                    GetImage = Casino.Properties.Resources._7_diamond;
                    break;
                case (46):
                    GetImage = Casino.Properties.Resources._8_diamond;
                    break;
                case (47):
                    GetImage = Casino.Properties.Resources._9_diamond;
                    break;
                case (48):
                    GetImage = Casino.Properties.Resources._10_diamond;
                    break;
                case (49):
                    GetImage = Casino.Properties.Resources.jack_diamond;
                    break;
                case (50):
                    GetImage = Casino.Properties.Resources.queen_diamond;
                    break;
                case (51):
                    GetImage = Casino.Properties.Resources.king_diamond;
                    break;

            }
        }
    }
}
