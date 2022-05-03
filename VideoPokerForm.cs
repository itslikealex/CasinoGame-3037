using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.Linq;
namespace Casino
{
	public partial class VideoPokerForm : Form
	{
		public VideoPokerForm(Player player)
		{
			InitializeComponent();
			this.AutoScaleMode = AutoScaleMode.Dpi;
			User = player;
		}


		Deck MyDeck = new Deck(1);
		Hand PlayerHand = new Hand();
		int BetAmount;
		int Winnings;
		int wintotal;
		int wincount = 0;
		Player User;

		private void exit(object sender, EventArgs e)
		{
			//add money to main bank
			VideoPokerForm.ActiveForm.Close();
		}

		private void PlayPoker(object sender, EventArgs e)
		{
			Playbt.Visible = false;
			Exitbt.Visible = false;
			tblLytPnlFlop.Visible = true;





			timer1.Start();
			timer2.Start();
			timer3.Start();
			timer4.Start();
			timer5.Start();

		}

		private void StopTimer1(object sender, EventArgs e)
		{
			timer1.Stop();
			flop1.Image = Casino.Properties.Resources.card_back1;

		}

		private void StopTimer2(object sender, EventArgs e)
		{
			timer2.Stop();
			flop2.Image = Casino.Properties.Resources.card_back1;

		}

		private void StopTimer3(object sender, EventArgs e)
		{
			timer3.Stop();
			flop3.Image = Casino.Properties.Resources.card_back1;

		}

		private void StopTimer4(object sender, EventArgs e)
		{
			timer4.Stop();
			flop4.Image = Casino.Properties.Resources.card_back1;

		}

		private void StopTimer5(object sender, EventArgs e)
		{
			timer5.Stop();
			flop5.Image = Casino.Properties.Resources.card_back1;
			BettingBox.Visible = true;
			Betbt.Visible = true;
			lblBetPrompt.Visible = true;
			lblDollar.Visible = true;

			PayoutTable.Visible = true;
			lblPayout.Visible = true;
		}

		private void Betpressed(object sender, EventArgs e)
		{
			
			if (int.TryParse(BettingBox.Text, out BetAmount))
			{

				if (BetAmount <= 10 && BetAmount > 0 && BetAmount < User.Cash)
				{
					User.BetCash(BetAmount);
					BettingBox.Visible = false;
					Betbt.Visible = false;
					lblBank.Text = User.Cash.ToString("C");
					lblBetPrompt.Text = "Enter how much you want to bet and click the button";
					lblBetPrompt.Visible = false;
					lblDollar.Visible = false;
					if (MyDeck.Cards.Count < 5)
					{
						MyDeck = new Deck(1);
					}
					timer1V2.Start();
					timer2V2.Start();
					timer3V2.Start();
					timer4V2.Start();
					timer5V2.Start();

				}
				else
				{
					lblBetPrompt.Text = "Please enter a number between 0 and 10 to bet";
				}
			}
            else
			{
				lblBetPrompt.Text = "Please enter Digits only";
			}
		}

		private void RedrawPressed(object sender, EventArgs e)
		{
			checkBox1.Visible = false;
			checkBox2.Visible = false;
			checkBox3.Visible = false;
			checkBox4.Visible = false;
			checkBox5.Visible = false;
			Redrawbt.Visible = false;
			var rng = new Random();
			int pick;
			if (MyDeck.Cards.Count < 5)
            {
				MyDeck = new Deck(1);
			}


			if (checkBox1.Checked == false)
			{
				//manual card draw from deck
				pick = rng.Next(MyDeck.Cards.Count);
				Card drawn = MyDeck.Cards[pick];
				MyDeck.Cards.Remove(drawn);
				//replace card in hand with drawn card
				PlayerHand.discardCard(0);
				PlayerHand.Cards.Insert(0, drawn);
				//display drawn card from hand 
				PlayerHand.Cards[0].LoadImage();
				flop1.Image = PlayerHand.Cards[0].GetImage;

			}
			if (checkBox2.Checked == false)
			{
				//manual card draw from deck
				pick = rng.Next(MyDeck.Cards.Count);
				Card drawn = MyDeck.Cards[pick];
				MyDeck.Cards.Remove(drawn);

				//replace card in hand with drawn card
				PlayerHand.discardCard(1);
				PlayerHand.Cards.Insert(1, drawn);
				//display drawn card from hand 
				PlayerHand.Cards[1].LoadImage();
				flop2.Image = PlayerHand.Cards[1].GetImage;
			}
			if (checkBox3.Checked == false)
			{
				//manual card draw from deck
				pick = rng.Next(MyDeck.Cards.Count);
				Card drawn = MyDeck.Cards[pick];
				MyDeck.Cards.Remove(drawn);
				//replace card in hand with drawn card
				PlayerHand.discardCard(2);
				PlayerHand.Cards.Insert(2, drawn);
				//display drawn card from hand 
				PlayerHand.Cards[2].LoadImage();
				flop3.Image = PlayerHand.Cards[2].GetImage;
			}
			if (checkBox4.Checked == false)
			{
				//manual card draw from deck
				pick = rng.Next(MyDeck.Cards.Count);
				Card drawn = MyDeck.Cards[pick];
				MyDeck.Cards.Remove(drawn);
				//replace card in hand with drawn card
				PlayerHand.discardCard(3);
				PlayerHand.Cards.Insert(3, drawn);
				//display drawn card from hand 
				PlayerHand.Cards[3].LoadImage();
				flop4.Image = PlayerHand.Cards[3].GetImage;
			}
			if (checkBox5.Checked == false)
			{
				//manual card draw from deck
				pick = rng.Next(MyDeck.Cards.Count);
				Card drawn = MyDeck.Cards[pick];
				MyDeck.Cards.Remove(drawn);
				//replace card in hand with drawn card
				PlayerHand.discardCard(4);
				PlayerHand.Cards.Insert(4, drawn);
				//display drawn card from hand 
				PlayerHand.Cards[4].LoadImage();
				flop5.Image = PlayerHand.Cards[4].GetImage;
			}

			Wintime.Start();
		}

		private void StopTimer1V2(object sender, EventArgs e)
		{
			timer1V2.Stop();
			MyDeck.DrawCard(PlayerHand);
			PlayerHand.Cards[0].LoadImage();
			flop1.Image = PlayerHand.Cards[0].GetImage;
			



		}

		private void StopTimer2V2(object sender, EventArgs e)
		{
			timer2V2.Stop();
			MyDeck.DrawCard(PlayerHand);
			PlayerHand.Cards[1].LoadImage();
			flop2.Image = PlayerHand.Cards[1].GetImage;
			
		}

		private void StopTimer3V3(object sender, EventArgs e)
		{
			timer3V2.Stop();
			MyDeck.DrawCard(PlayerHand);
			PlayerHand.Cards[2].LoadImage();
			flop3.Image = PlayerHand.Cards[2].GetImage;
			
		}

		private void StopTimer4V4(object sender, EventArgs e)
		{
			timer4V2.Stop();
			MyDeck.DrawCard(PlayerHand);
			PlayerHand.Cards[3].LoadImage();
			flop4.Image = PlayerHand.Cards[3].GetImage;
			
		}

		private void StopTimer5V5(object sender, EventArgs e)
		{
			timer5V2.Stop();
			MyDeck.DrawCard(PlayerHand);
			PlayerHand.Cards[4].LoadImage();
			flop5.Image = PlayerHand.Cards[4].GetImage;

			checkBox1.Visible = true;
			checkBox2.Visible = true;
			checkBox3.Visible = true;
			checkBox4.Visible = true;
			checkBox5.Visible = true;
			Redrawbt.Visible = true;
		}
		//////////////////////////////////////////

			//functions
			//these are used to get poker board state
			int evaluation(State current)
			{
				if (royal_flush(current))
				{
					return 9;
				}
				else if (straight_flush(current))
				{
					return 8;
				}
				else if (four_kind(current))
				{
					return 7;
				}
				else if (fullhouse(current))
				{
					return 6;
				}
				else if (flush(current))
				{
					return 5;
				}
				else if (straight(current))
				{
					return 4;
				}
				else if (three_kind(current))
				{
					return 3;
				}
				else if (two_pair(current))
				{
					return 2;
				}
				else if (one_pair(current))
				{
					return 1;
				}
				else
				{
					return 0;
				}
			}

			bool one_pair(State current)
			{
				if (current.AceCount >= 2)
				{
					return true;
				}
				else if (current.Count2 >= 2)
				{
					return true;
				}
				else if (current.Count3 >= 2)
				{
					return true;
				}
				else if (current.Count4 >= 2)
				{
					return true;
				}
				else if (current.Count5 >= 2)
				{
					return true;
				}
				else if (current.Count6 >= 2)
				{
					return true;
				}
				else if (current.Count7 >= 2)
				{
					return true;
				}
				else if (current.Count8 >= 2)
				{
					return true;
				}
				else if (current.Count9 >= 2)
				{
					return true;
				}
				else if (current.Count10 >= 2)
				{
					return true;
				}
				else if (current.JackCount >= 2)
				{
					return true;
				}
				else if (current.QueenCount >= 2)
				{
					return true;
				}
				else if (current.KingCount >= 2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			bool two_pair(State current)
			{
				int check;
				//check for 3
				if (current.AceCount >= 2)
				{
					check = 1;
				}
				else if (current.Count2 >= 2)
				{
					check = 2;
				}
				else if (current.Count3 >= 2)
				{
					check = 3;
				}
				else if (current.Count4 >= 2)
				{
					check = 4;
				}
				else if (current.Count5 >= 2)
				{
					check = 5;
				}
				else if (current.Count6 >= 2)
				{
					check = 6;
				}
				else if (current.Count7 >= 2)
				{
					check = 7;
				}
				else if (current.Count8 >= 2)
				{
					check = 8;
				}
				else if (current.Count9 >= 2)
				{
					check = 9;
				}
				else if (current.Count10 >= 2)
				{
					check = 10;
				}
				else if (current.JackCount >= 2)
				{
					check = 11;
				}
				else if (current.QueenCount >= 2)
				{
					check = 12;
				}
				else if (current.KingCount >= 2)
				{
					check = 13;
				}
				else
				{
					return false;
				}


				//check for 2
				if (current.AceCount >= 2 && check != 1)
				{
					return true;
				}
				else if (current.Count2 >= 2 && check != 2)
				{
					return true;
				}
				else if (current.Count3 >= 2 && check != 3)
				{
					return true;
				}
				else if (current.Count4 >= 2 && check != 4)
				{
					return true;
				}
				else if (current.Count5 >= 2 && check != 5)
				{
					return true;
				}
				else if (current.Count6 >= 2 && check != 6)
				{
					return true;
				}
				else if (current.Count7 >= 2 && check != 7)
				{
					return true;
				}
				else if (current.Count8 >= 2 && check != 8)
				{
					return true;
				}
				else if (current.Count9 >= 2 && check != 9)
				{
					return true;
				}
				else if (current.Count10 >= 2 && check != 10)
				{
					return true;
				}
				else if (current.JackCount >= 2 && check != 11)
				{
					return true;
				}
				else if (current.QueenCount >= 2 && check != 12)
				{
					return true;
				}
				else if (current.KingCount >= 2 && check != 13)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			bool three_kind(State current)
			{
				if (current.AceCount >= 3)
				{
					return true;
				}
				else if (current.Count2 >= 3)
				{
					return true;
				}
				else if (current.Count3 >= 3)
				{
					return true;
				}
				else if (current.Count4 >= 3)
				{
					return true;
				}
				else if (current.Count5 >= 3)
				{
					return true;
				}
				else if (current.Count6 >= 3)
				{
					return true;
				}
				else if (current.Count7 >= 3)
				{
					return true;
				}
				else if (current.Count8 >= 3)
				{
					return true;
				}
				else if (current.Count9 >= 3)
				{
					return true;
				}
				else if (current.Count10 >= 3)
				{
					return true;
				}
				else if (current.JackCount >= 3)
				{
					return true;
				}
				else if (current.QueenCount >= 3)
				{
					return true;
				}
				else if (current.KingCount >= 3)
				{
					return true;
				}
				else
				{
					return false;
				}

			}
			bool four_kind(State current)
			{
				if (current.AceCount >= 4)
				{
					return true;
				}
				else if (current.Count2 >= 4)
				{
					return true;
				}
				else if (current.Count3 >= 4)
				{
					return true;
				}
				else if (current.Count4 >= 4)
				{
					return true;
				}
				else if (current.Count5 >= 4)
				{
					return true;
				}
				else if (current.Count6 >= 4)
				{
					return true;
				}
				else if (current.Count7 >= 4)
				{
					return true;
				}
				else if (current.Count8 >= 4)
				{
					return true;
				}
				else if (current.Count9 >= 4)
				{
					return true;
				}
				else if (current.Count10 >= 4)
				{
					return true;
				}
				else if (current.JackCount >= 4)
				{
					return true;
				}
				else if (current.QueenCount >= 4)
				{
					return true;
				}
				else if (current.KingCount >= 4)
				{
					return true;
				}
				else
				{
					return false;
				}

			}

			bool fullhouse(State current)
			{
				int check;
				//check for 3
				if (current.AceCount >= 3)
				{
					check = 1;
				}
				else if (current.Count2 >= 3)
				{
					check = 2;
				}
				else if (current.Count3 >= 3)
				{
					check = 3;
				}
				else if (current.Count4 >= 3)
				{
					check = 4;
				}
				else if (current.Count5 >= 3)
				{
					check = 5;
				}
				else if (current.Count6 >= 3)
				{
					check = 6;
				}
				else if (current.Count7 >= 3)
				{
					check = 7;
				}
				else if (current.Count8 >= 3)
				{
					check = 8;
				}
				else if (current.Count9 >= 3)
				{
					check = 9;
				}
				else if (current.Count10 >= 3)
				{
					check = 10;
				}
				else if (current.JackCount >= 3)
				{
					check = 11;
				}
				else if (current.QueenCount >= 3)
				{
					check = 12;
				}
				else if (current.KingCount >= 3)
				{
					check = 13;
				}
				else
				{
					return false;
				}
				//check for 2
				if (current.AceCount >= 2 && check != 1)
				{
					return true;
				}
				else if (current.Count2 >= 2 && check != 2)
				{
					return true;
				}
				else if (current.Count3 >= 2 && check != 3)
				{
					return true;
				}
				else if (current.Count4 >= 2 && check != 4)
				{
					return true;
				}
				else if (current.Count5 >= 2 && check != 5)
				{
					return true;
				}
				else if (current.Count6 >= 2 && check != 6)
				{
					return true;
				}
				else if (current.Count7 >= 2 && check != 7)
				{
					return true;
				}
				else if (current.Count8 >= 2 && check != 8)
				{
					return true;
				}
				else if (current.Count9 >= 2 && check != 9)
				{
					return true;
				}
				else if (current.Count10 >= 2 && check != 10)
				{
					return true;
				}
				else if (current.JackCount >= 2 && check != 11)
				{
					return true;
				}
				else if (current.QueenCount >= 2 && check != 12)
				{
					return true;
				}
				else if (current.KingCount >= 2 && check != 13)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			
			bool flush(State current)
			{
				if (current.SpadesCount >= 5)
				{
					return true;
				}
				else if (current.ClubsCount >= 5)
				{
					return true;
				}
				else if (current.HeartsCount >= 5)
				{
					return true;
				}
				else if (current.DiamondsCount >= 5)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			bool straight(State current)
			{
				if (current.AceCount >= 1 && current.Count2 >= 1 && current.Count3 >= 1 && current.Count4 >= 1 && current.Count5 >= 1)
				{
					return true;
				}
				else if (current.Count2 >= 1 && current.Count3 >= 1 && current.Count4 >= 1 && current.Count5 >= 1 && current.Count6 >= 1)
				{
					return true;
				}
				else if (current.Count3 >= 1 && current.Count4 >= 1 && current.Count5 >= 1 && current.Count6 >= 1 && current.Count7 >= 1)
				{
					return true;
				}
				else if (current.Count4 >= 1 && current.Count5 >= 1 && current.Count6 >= 1 && current.Count7 >= 1 && current.Count8 >= 1)
				{
					return true;
				}
				else if (current.Count5 >= 1 && current.Count6 >= 1 && current.Count7 >= 1 && current.Count8 >= 1 && current.Count9 >= 1)
				{
					return true;
				}
				else if (current.Count6 >= 1 && current.Count7 >= 1 && current.Count8 >= 1 && current.Count9 >= 1 && current.Count10 >= 1)
				{
					return true;
				}
				else if (current.Count7 >= 1 && current.Count8 >= 1 && current.Count9 >= 1 && current.Count10 >= 1 && current.JackCount >= 1)
				{
					return true;
				}
				else if (current.Count8 >= 1 && current.Count9 >= 1 && current.Count10 >= 1 && current.JackCount >= 1 && current.QueenCount >= 1)
				{
					return true;
				}
				else if (current.Count9 >= 1 && current.Count10 >= 1 && current.JackCount >= 1 && current.QueenCount >= 1 && current.KingCount >= 1)
				{
					return true;
				}
				else if (current.Count10 >= 1 && current.JackCount >= 1 && current.QueenCount >= 1 && current.KingCount >= 1 && current.AceCount >= 1)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			bool straight_flush(State current)
			{
				if (flush(current))
				{
					if (current.AceCount >= 1 && current.Count2 >= 1 && current.Count3 >= 1 && current.Count4 >= 1 && current.Count5 >= 1)
					{
						return true;
					}
					else if (current.Count2 >= 1 && current.Count3 >= 1 && current.Count4 >= 1 && current.Count5 >= 1 && current.Count6 >= 1)
					{
						return true;
					}
					else if (current.Count3 >= 1 && current.Count4 >= 1 && current.Count5 >= 1 && current.Count6 >= 1 && current.Count7 >= 1)
					{
						return true;
					}
					else if (current.Count4 >= 1 && current.Count5 >= 1 && current.Count6 >= 1 && current.Count7 >= 1 && current.Count8 >= 1)
					{
						return true;
					}
					else if (current.Count5 >= 1 && current.Count6 >= 1 && current.Count7 >= 1 && current.Count8 >= 1 && current.Count9 >= 1)
					{
						return true;
					}
					else if (current.Count6 >= 1 && current.Count7 >= 1 && current.Count8 >= 1 && current.Count9 >= 1 && current.Count10 >= 1)
					{
						return true;
					}
					else if (current.Count7 >= 1 && current.Count8 >= 1 && current.Count9 >= 1 && current.Count10 >= 1 && current.JackCount >= 1)
					{
						return true;
					}
					else if (current.Count8 >= 1 && current.Count9 >= 1 && current.Count10 >= 1 && current.JackCount >= 1 && current.QueenCount >= 1)
					{
						return true;
					}
					else if (current.Count9 >= 1 && current.Count10 >= 1 && current.JackCount >= 1 && current.QueenCount >= 1 && current.KingCount >= 1)
					{
						return true;
					}
					else if (current.Count10 >= 1 && current.JackCount >= 1 && current.QueenCount >= 1 && current.KingCount >= 1 && current.AceCount >= 1)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}

			bool royal_flush(State current)
			{
				if (flush(current))
				{
					if (current.Count10 >= 1 && current.JackCount >= 1 && current.QueenCount >= 1 && current.KingCount >= 1 && current.AceCount >= 1)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}

		int multiplier(int winstate)
		{
			switch (winstate)
			{
				case 0:
					return 0;
					
				case 1:
					return 1;
					
				case 2:
					return 2;
					
				case 3:
					return 3;
					
				case 4:
					return 5;
					
				case 5:
					return 7;
					
				case 6:
					return 10;
					
				case 7:
					return 50;
					
				case 8:
					return 200;
					
				case 9:
					return 500;
					
				default:
					return 0;
			}
		
		}

		private void WinTimer(object sender, EventArgs e)
		{
			Wintime.Stop();
			//face cards
			const int jack = 10;
			const int queen = 11;
			const int king = 12;
			const int ace = 0;
			//type cards
			const int spades = 0;
			const int clubs = 1;
			const int hearts = 2;
			const int diamonds = 3;

			int spadesCount = 0;
			int clubsCount = 0;
			int heartsCount = 0;
			int diamondsCount = 0;
			int aceCount = 0;     //0
			int count2 = 0;//1
			int count3 = 0;//2
			int count4 = 0;//3
			int count5 = 0;//4
			int count6 = 0;//5
			int count7 = 0;//6
			int count8 = 0;//7
			int count9 = 0;//8
			int count10 = 0;//9
			int jackCount = 0;//10
			int queenCount = 0;//11
			int kingCount = 0;//12
			//get info from table
			for (int i = 0; i < 5; i++)
			{
				switch (PlayerHand.Cards[i].CardSuit)
				{
					case spades:
						spadesCount++;
						break;
					case clubs:
						clubsCount++;
						break;
					case hearts:
						heartsCount++;
						break;
					case diamonds:
						diamondsCount++;
						break;
				}
				switch (PlayerHand.Cards[i].CardFace)
				{
					case ace:
						aceCount++;
						break;
					case 1:
						count2++;
						break;
					case 2:
						count3++;
						break;
					case 3:
						count4++;
						break;
					case 4:
						count5++;
						break;
					case 5:
						count6++;
						break;
					case 6:
						count7++;
						break;
					case 7:
						count8++;
						break;
					case 8:
						count9++;
						break;
					case 9:
						count10++;
						break;
					case jack:
						jackCount++;
						break;
					case queen:
						queenCount++;
						break;
					case king:
						kingCount++;
						break;
			}
		}

			//create the
			//game state object
			State current = new State
			(
			 spadesCount,
			 clubsCount,
			 heartsCount,
			 diamondsCount,
			 aceCount,
			 count2,
			 count3,
			 count4,
			 count5,
			 count6,
			 count7,
			 count8,
			 count9,
			 count10,
			 jackCount,
			 queenCount,
			 kingCount
			 );

		//refer to evaluation function and the result is an int
		//int value can be used to make winnings 
			int win = evaluation(current);
			int mult = multiplier(win);
			Winnings = BetAmount * mult;
			User.PayoutCash(Winnings);
			lblBank.Text = User.Cash.ToString("C");
			if (win < 2)
            {
				
				Winpanel.BackColor = Color.Salmon;
				lblDecision.Text = "You Lose";
				
				if (win == 0)
                {
					lblCondition.Text = "You only had high Card and lost your money";
					lblmoneychange.Text = "";
					lblpayout0.BackColor = Color.Yellow;
					lblpayout0_0.BackColor = Color.Yellow;
					lblCurrentWin.Text = $"Current Winnings: 0";
				}
				else  //win == 1
                {
					lblCondition.Text = "You only had a pair and made back";
					lblmoneychange.Text = $"$ {BetAmount * mult}";
					lblpayout1.BackColor = Color.Yellow;
					lblpayout0_1.BackColor = Color.Yellow;
					lblCurrentWin.Text = $"Current Winnings: 0";
				}
            }
			else
            {
				Winpanel.BackColor = Color.Lime;
				lblDecision.Text = "You Win";
				wincount++;
				lblmoneychange.Text = $"$ {BetAmount * mult}";
				wintotal += Winnings;
				switch (win)
                {
					case 2:
						lblCondition.Text = "You won with Two Pair and made";
						lblpayout2.BackColor = Color.Yellow;
						lblpayout0_2.BackColor = Color.Yellow;
						break;
					case 3:
						lblCondition.Text = "You won with Three of a Kind and made";
						lblpayout3.BackColor = Color.Yellow;
						lblpayout0_3.BackColor = Color.Yellow;
						break;
					case 4:
						lblCondition.Text = "You won with Straight and made";
						lblpayout4.BackColor = Color.Yellow;
						lblpayout0_4.BackColor = Color.Yellow;
						break;
					case 5:
						lblCondition.Text = "You won with Flush and made";
						lblpayout5.BackColor = Color.Yellow;
						lblpayout0_5.BackColor = Color.Yellow;
						break;
					case 6:
						lblCondition.Text = "You won with Full house and made";
						lblpayout6.BackColor = Color.Yellow;
						lblpayout0_6.BackColor = Color.Yellow;
						break;
					case 7:
						lblCondition.Text = "You won with Four of a kind and made";
						lblpayout7.BackColor = Color.Yellow;
						lblpayout0_7.BackColor = Color.Yellow;
						break;
					case 8:
						lblCondition.Text = "You won with Straight Flush and made";
						lblpayout8.BackColor = Color.Yellow;
						lblpayout0_8.BackColor = Color.Yellow;
						break;
					case 9:
						lblCondition.Text = "You won with Royal Flush and made";
						lblpayout9.BackColor = Color.Yellow;
						lblpayout0_9.BackColor = Color.Yellow;
						break;
				}
				lblCurrentWin.Text = $"Current Winnings: {Winnings}";
				lblTotalWins.Text = $"Total Winnings: {wintotal}";

			}
			Winpanel.Visible = true;
			
			lblWinCount.Text = $"Wins: {wincount}";
		}

        private void OkPressed(object sender, EventArgs e)
        {
			//reset the game
			Winpanel.Visible = false;
			Playbt.Visible = true;
			Exitbt.Visible = true;
			tblLytPnlFlop.Visible = false;
			checkBox1.Checked = false;
			checkBox2.Checked = false;
			checkBox3.Checked = false;
			checkBox4.Checked = false;
			checkBox5.Checked = false;
			lblpayout0.BackColor = Color.White;
			lblpayout0_0.BackColor = Color.White;
			lblpayout1.BackColor = Color.White;
			lblpayout0_1.BackColor = Color.White;
			lblpayout2.BackColor = Color.White;
			lblpayout0_2.BackColor = Color.White;
			lblpayout3.BackColor = Color.White;
			lblpayout0_3.BackColor = Color.White;
			lblpayout4.BackColor = Color.White;
			lblpayout0_4.BackColor = Color.White;
			lblpayout5.BackColor = Color.White;
			lblpayout0_5.BackColor = Color.White;
			lblpayout6.BackColor = Color.White;
			lblpayout0_6.BackColor = Color.White;
			lblpayout7.BackColor = Color.White;
			lblpayout0_7.BackColor = Color.White;
			lblpayout8.BackColor = Color.White;
			lblpayout0_8.BackColor = Color.White;
			lblpayout9.BackColor = Color.White;
			lblpayout0_9.BackColor = Color.White;
			flop1.Image = null;
			flop2.Image = null;
			flop3.Image = null;
			flop4.Image = null;
			flop5.Image = null;
			PayoutTable.Visible = false;
			lblPayout.Visible = false;
			PlayerHand.discardHand();


		}


    }
}

	//CARD CLASS//////////////////////////////////////////////
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
			GetCardName();
			
		}

		public void LoadImage()
		{
			switch (cardNum)
			{
				case (0):
							//Casino
					GetImage = Casino.Properties.Resources.ace_spade;
					break;
				case (1):
					GetImage = GetImage = Casino.Properties.Resources.ace_spade;
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


//////////////////////////////////////

/// <summary>
/// Hand
/// </summary>


public class Hand
{
	public List<Card> Cards = new List<Card>();
	public void showHand()
	{
		Console.WriteLine("This hand has: ");
		for (int i = 0; i < Cards.Count; i++)
		{
			Console.WriteLine(Cards[i].CardName);
		}
	}
	public void discardCard(int disc)
	{
		Card discard = Cards[disc];
		Cards.Remove(discard);
	}
	public void discardHand()
	{
		while (Cards.Count > 0)
		{
			discardCard(0);
		}
	}

}

/// <summary>
/// Deck
/// </summary>
public class Deck
{
	public List<Card> Cards = new List<Card>();
	//public List <Card> ShuffledCards = new List <Card>();
	public int DeckCount;
	public Deck(int deckCount)
	{
		this.DeckCount = deckCount;
		//Console.WriteLine("Deck was initialized");
		for (int i = 0; i < deckCount; i++)
		{
			for (int j = 0; j < 52; j++)
			{
				Card card = new Card(j);
				Cards.Add(card);
				//Console.WriteLine(Cards[j].CardName);
			}
		}
		//ShuffleDeck();
	}

	public void DrawCard(Hand hand)
	{
		var rng = new Random();
		int pick;
		pick = rng.Next(Cards.Count);
		Card drawn = Cards[pick];
		Cards.Remove(drawn);
		hand.Cards.Add(drawn);
	}
	public void DisplayDeck()
	{
		for (int i = 0; i < Cards.Count; i++)
		{
			Console.WriteLine(Cards[i].CardName);
		}
	}

}
/// <summary>
/// Player class
/// </summary>
public class Player
{
	public string PlayerName { get; set; }
	public int Cash { get; set; }
	public Player(string name, int cash)
	{
		PlayerName = name;
		Cash = cash;
	}
	public void BetCash(int bet)
	{
		Cash -= bet;
	}
	public void PayoutCash(int payout)
	{
		Cash += payout;
	}
	public void Display()
	{
		Console.WriteLine(PlayerName);
		Console.WriteLine(Cash);
	}
}












//game state class for poker to pass to game state evalutations
public class State
	{
		public State(int spadesCount,
					int clubsCount,
					int heartsCount,
					int diamondsCount,

					int aceCount,
					int count2,
					int count3,
					int count4,
					int count5,
					int count6,
					int count7,
					int count8,
					int count9,
					int count10,
					int jackCount,
					int queenCount,
					int kingCount)
		{
			SpadesCount = spadesCount;
			ClubsCount = clubsCount;
			HeartsCount = heartsCount;
			DiamondsCount = diamondsCount;

			AceCount = aceCount;
			Count2 = count2;
			Count3 = count3;
			Count4 = count4;
			Count5 = count5;
			Count6 = count6;
			Count7 = count7;
			Count8 = count8;
			Count9 = count9;
			Count10 = count10;
			JackCount = jackCount;
			QueenCount = queenCount;
			KingCount = kingCount;
		}

		public int SpadesCount { get; }
		public int ClubsCount { get; }
		public int HeartsCount { get; }
		public int DiamondsCount { get; }
		public int AceCount { get; }
		public int Count2 { get; }
		public int Count3 { get; }
		public int Count4 { get; }
		public int Count5 { get; }
		public int Count6 { get; }
		public int Count7 { get; }
		public int Count8 { get; }
		public int Count9 { get; }
		public int Count10 { get; }
		public int JackCount { get; }
		public int QueenCount { get; }
		public int KingCount { get; }

	}

