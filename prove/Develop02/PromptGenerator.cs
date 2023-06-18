public class PromptGenerator
{
    public Random random = new Random();
    public List<string> _promptlist = new List<string>{"What are all the things you're grateful for today?","What was something positive you experienced recently?","What are some things that give your life meaning?","What are three good things about today?","How do you manage your emotions, and how might you manage them more effectively?"};

    public string RandomPrompt(){
        int randomIndex = random.Next(_promptlist.Count);
        string randomPrompt = _promptlist[randomIndex];
        return randomPrompt;
    }
}