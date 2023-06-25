public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = new List<Word>();
        List<String> wordsList = text.Split(" ").ToList();

        foreach (string words in wordsList)
        {
            Word word = new Word(words);
            _words.Add(word);
        }
    }

    public Scripture(){
        string text = "";
        _words = new List<Word>();
        //Creating a List of references and Scripture text.
        List<Reference> referenceList = new List<Reference>();
        List<string> scriptureList = new List<string>();
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        referenceList.Add(reference1);
        scriptureList.Add("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Reference reference2 = new Reference("Nephi", 3, 7);
        referenceList.Add(reference2);
        scriptureList.Add("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Reference reference3 = new Reference("Doctrine and Covenants", 1, 37, 38);
        referenceList.Add(reference3);
        scriptureList.Add("Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same.");
        Reference reference4=new Reference("John",3,5);
        referenceList.Add(reference4);
        scriptureList.Add("Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        //Selecting a random index from 0 to 3 from the reference and scripture list to add the value  _scriptureText and _reference variables.
        Random random1 = new Random();
        int randomIndex1 = random1.Next(0, 3);
        text = scriptureList[randomIndex1];
        _reference = referenceList[randomIndex1];
        //Adding the words from the scripture to the _wordsList 

        List<String> wordsList = text.Split(" ").ToList();

        foreach (string words in wordsList)
        {
            Word word = new Word(words);
            _words.Add(word);
        }
    }

    public void HideRandomWords()
    {
        int numberOfWords = _words.Count();
        Random random = new Random();

        //Calling the Visible Words method to know how many words are visible
        int visibleWords = VisibleWords();

        if (visibleWords > 5)
        {
            int numberOfRandomWords = random.Next(1, 5);
            for (int i = 0; i < numberOfRandomWords; i++)
            {
                int index = 0;
                int randomIndex = random.Next(numberOfWords);
                //The program will check if the word is hidden or shown.
                bool isHidden = _words[randomIndex].IsHidden();
                //If the word is hidden the program will do a while to find a word from the _wordsList that is shown to hide it.
                if (isHidden == true)
                {
                    while (isHidden == true)
                    {
                        if (index < _words.Count())
                        {
                            isHidden = _words[index].IsHidden();
                            _words[index].Hide();
                            index += 1;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                }
                //If the word is shown, the program will hide the word.
                else
                {
                    _words[randomIndex].Hide();
                }
            }
        }
        //If the number of visible words is Less than 5, the program will hide the rest of the Shown words.
        else
        {
            for (int i = 0; i < visibleWords; i++)
            {
                int index = 0;
                int randomIndex = random.Next(numberOfWords);
                //The program will check if the word is hidden or shown.
                bool isHidden = _words[randomIndex].IsHidden();
                 //If the word is hidden the program will do a while to find a word from the _wordsList that is shown to hide it.
                if (isHidden == true)
                {
                    while (isHidden == true)
                    {
                        if (index < _words.Count())
                        {
                            isHidden = _words[index].IsHidden();
                            _words[index].Hide();
                            index += 1;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                }
                //If the word is shown, the program will hide the word.
                else
                {
                    _words[randomIndex].Hide();
                }
            }
        }
    }

    public bool IsCompletelyHidden(){

        bool completelyHidden = false;
        int numberOfVisibleWords = 0;
        foreach (Word word in _words)
        {
            bool isHidden = word.IsHidden();
            if (isHidden == false)
            {
                numberOfVisibleWords = +1;
            }
        }
        if (numberOfVisibleWords == 0)
        {
            completelyHidden = true;
        }

        return completelyHidden;
    }

    public string GetDisplayText(){
        string displayText = "";

        foreach(Word word in _words){
            if(word.IsHidden() == false)
            {
                displayText += word.GetDisplayText() + " ";
            }
            else
            {
                displayText += new string('_', word.GetDisplayText().Length) + " ";
            }
        }

        return $"{_reference.GetDisplayText()} {displayText}";

    }

    private int VisibleWords()
    {
        //This method is just used to know the amount of words currently visible. To use in other methods.
        int numberOfVisibleWords = 0;
        foreach (Word word in _words)
        {
            bool isHidden = word.IsHidden();
            if (isHidden == false)
            {
                numberOfVisibleWords = +1;
            }
        }
        return numberOfVisibleWords;
    }
    
}