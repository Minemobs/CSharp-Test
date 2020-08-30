using System;

namespace Tuto
{
class MaClassDelegate
{

    private delegate string DelegateAfficher(string text);

    private string Maj(string text){
        return text.ToUpper();
    }

    private string min(string text){
        return text.ToLower();
    }

    public void MainipulerString(string text)
    {
        DelegateAfficher method = Maj;
        Console.WriteLine(method(text));
        Console.WriteLine("-------");

        method = min;
        Console.WriteLine(method(text));
    }
}
}