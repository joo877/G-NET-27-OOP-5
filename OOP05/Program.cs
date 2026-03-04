namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region part01
            #region Q1
            /*
             An interface defines a contract that a class must follow

            benefits :  1- Enable polymorphism without inheritance
                        2- Remove tight coupling between classes
                        3-Enable multiple inheritance (behavior)
             */

            #endregion
            #region Q2
            /*
            A-  Problem: Method Name Conflict
            when called Greet() method from Translator inistance same behavior in two interface 

            B- To solve this problem using Explicit Implementation
            
            class Translator : IEnglishSpeaker, IArabicSpeaker
               {
                       void IEnglishSpeaker.Greet()
                        {
                       Console.WriteLine("Hello");
                        }

                        void IArabicSpeaker.Greet()
                        {
                       Console.WriteLine("Ahlan");
                        }
   
             }



            C- After applied Explicit Implementation  Cannot call  Greet() method  directly on a Translator object 
             translator.Greet() //invalid because Greet() follow interface now not class (translator cannot be access Greet() method now)

              IEnglishSpeaker english = new  Translator (); 
              english.Greet();  // call Greet() method from  IEnglishSpeaker

             IArabicSpeaker arabic = new  Translator (); 
              arabic.Greet();  // call Greet() method from  IArabicSpeaker

          //  also can cast directory 

            Translator t = new Translator();
                ((IEnglishSpeaker)t).Greet();
                ((IArabicSpeaker)t).Greet();

             */
            #endregion
            #region Q3
            /*
              shallow copy : copy direct object and don't copy nested object but copy refrences only
               using when we want Two objects, same inner references  Changing inner object affects both copies
           
            deep copy : copy direct object  nested object,
            using when we want Two completely independent objects Changing one never affects the other

             risk in shallow copy : when change the reference field the original will be change also 
             
             
             */
            #endregion
            #region Q4
            /*
               OutPut : Dev - Testing 
                         QA - Testing


            shallow copy : copy direct object and don't copy nested object but copy refrences only

            Title is string immutable so create new  object  with new address and e2 refere to this address "QA"
               so e1.Title still refere "Dev"

             Dept is an object from Department so e1,e2 shared the same object any change from each one 
             another affected
             */

            #endregion
            #endregion
        }
    }
}
