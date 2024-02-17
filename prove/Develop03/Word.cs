class Word
{
    private bool hidden;
    private string script;

    public Word(string script){
        this.script = script;
        this.hidden = false;
    }

    public void Hide() {
        if (script != "_"){
            hidden = true;
        }
        //hide your word
    }
    public bool isHidden(){
        return hidden;
    }
    //display 
    public void display(){
        //Update to use the hidden variable to change how it's displayed 
        if (hidden == true) {

            script = "_";
            Console.Write(script);
        } 
        else {
            Console.Write(script);
        }
    }
}