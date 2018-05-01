using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._02_Two
{
    delegate void StringProcessor(string input);


    class Person
    {
        string name;

        public Person(string name) { this.name = name; }

        public void Say(string messgae)
        {
            Console.WriteLine("{0} says:{1}", name, messgae);
        }
    }

    class Background
    {
        public static void Note(string note)
        {
            Console.WriteLine("[{0}]", note);
        }
    }



    public class _01_Delegate
    {
        event StringProcessor SP_Event;

        public void Test()
        {
            Person jon = new Person("jon");
            Person tom = new Person("tom");
            StringProcessor jonsVoice, tomsVoice;
            
            jonsVoice = new StringProcessor(jon.Say);
            tomsVoice = tom.Say;
            SP_Event += Background.Note;
            jonsVoice("Hello Tom");
            tomsVoice("Hi Jon");
            SP_Event.Invoke("I am Bg");
            SP_Event("Bg isMe");
        }

    }
}
