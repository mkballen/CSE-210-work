class Scripture
{
    private List <Word> words;

    public Scripture(string w){
       words = new List <Word>();
       var texts = w.Split(" ");

       foreach (var text in texts){
            var word = new Word(text);
            words.Add(word);
       }
    }
    
    public void HideWords()
    {
        
        //list of word objects
        for (int s = 0; s < 3; ++s ){
            if (Leave() == true){
                break;
            }
            //randomly pick 3 words to hide
            int length = words.Count();
            Random rnd = new System.Random();
            int num = rnd.Next(0, length);

            var randomWord = words[num];
            
            //hide randomWord
            while (randomWord.isHidden()){

                num = rnd.Next(0, length);
                randomWord = words[num];

                             
            }
            randomWord.Hide();
            
        }
   
    }

    public bool Leave(){
        bool end = true;
            foreach (var word in words)
                {
                    if (word.isHidden() == false){
                        end = false;
                    }
                }
        return end;

    }
    //display scripture
    public void Display(){
        foreach (var word in words){
            word.display();
            Console.Write(" ");
        }
        
        //displaying each word object
    }
}