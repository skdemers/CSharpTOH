using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthTrainingLog
{
    class TrainingLog
    {   
        //Acesss modifiers
        ///public
        ///private - default - only accessible within the class


        ////Constructor - a method definition the same name as the class. Allows us to take control of the initialization of an object
        //is invoked to when 'new' keyword is is used to create a new TrainingLog
        //ctro tab tab is code snippet
        public TrainingLog()
        {
            sessions = new List<string>();
        }
        
        //session is scoped to this method
        public void AddSession(string session)
        {
            sessions.Add(session);

        }

        public List<string> sessions;
    }
}
