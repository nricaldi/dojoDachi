using System;

namespace dojoDachi
{
    public class DojoDachi
    {
        public int Happiness {get; set;}
        public int Fullness {get; set;}
        public int Energy {get; set;}
        public int Meals {get; set;}
        public string Reaction {get; set;}
        public string ImageUrl {get; set;}

        public DojoDachi(){
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
            Reaction = "Welcome to your Dojo Dachi. Use the buttons below to play!";
            ImageUrl = "start";
        }

        public void Feed(){
            if(Meals > 0){
                Random rand = new Random();
                int r  = rand.Next(5,11);
                int chance = rand.Next(0,4);
                Meals -= 1;

                if (chance == 0){
                    Reaction = $"Your Dojodachi did not want to eat! Meals -1, Fullness did not change";            
                    ImageUrl = "notLikeFood";
                }

                else{
                    Fullness += r;
                    Energy += 5;
                    Reaction = $"Your Dojodachi ate! Meals -1, Fullness +{r}. Energy +5";
                    ImageUrl = "likeFood";                    
                }
            }
            else{
                Reaction = "You do not have any meals left. Work to get more meals";
                ImageUrl = "hungry";
            }
        }

        public void  Play(){
            if(Energy <= 5){
                Reaction = "Your Dojodachi does not have enough energy to play. Eat or sleep to get some more energy.";
                ImageUrl = "tired";
            }
            else{
                Energy -= 5;
                Random rand = new Random();
                int r  = rand.Next(5,11);
                int chance = rand.Next(0,4);

                if (chance == 0){
                    Reaction = $"Your Dojodachi did not want to play. Energy -5, Happiness did not change";
                    ImageUrl = "sad";
                }
                else{
                    Happiness += r;
                    Reaction = $"You played with your Dojodachi! Happiness +{r}, Energy -5";
                    ImageUrl = "play";
                }
            }
        }

        public void Work(){
            Random rand = new Random();
            int r = rand.Next(1,4);
            Energy -= 5;
            Meals += r;
            Reaction = $"Your Dojodachi earned {r} meals at work!";
            ImageUrl = "work";
        }

        public void Sleep(){
            Energy += 15;
            Fullness -= 5;
            Happiness -= 5;
            Reaction = "Your DojoDachi took a good nap! Energy +15, Fullness -5, Happiness -5";
            ImageUrl = "sleep";
        }

        public bool Continue(){
            if ((Fullness >= 100 && Happiness >= 100 && Energy >= 100) || (Fullness <= 0) || (Happiness <= 0) || (Energy <= 0))
                return false;
            else
                return true;
        }

        public void winOrLose(){
            if (Fullness >= 100 && Happiness >= 100 && Energy >= 100){
                Reaction = "Congratulations! You Win";
                ImageUrl = "win";
            }
            else{
                Reaction = "Your Dojodachi has passed away.";
                ImageUrl = "dead";
            }
        }
    }
}