using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    abstract class UserError
    {
       
        public UserError()
        {
            //this.UEMessage();


        }

        public virtual string UEMessage(string str="Some text")
        {
           
            return str;
        }

        public virtual string UEMessage()
        {
            return "Some text";
           
        }
    }

    class NumericInputError: UserError

    {
        public string Message = "You tried to use a numeric input in a text only field. This fired an error!";;
        
        public void NumericInputErrorr()
        {
            //this.UEMessage();


        }



        public override string UEMessage(string str = "You tried to use a numeric input in a text only field. This fired an error!")
        {
            return str;
        }

        public override string UEMessage()
        {
            return this.Message;

        }
    }

      
   

    class TextInputError : UserError
    {
        public string Message = "You tried to use a text input in anumericonly field. This fired an error!";
        public TextInputError()
        {
           return Message;
           
        }

        public override string UEMessage(string str = "You tried to use a text input in anumericonly field. This fired an error!")
        {
            return str;
        }
        public override string UEMessage()
        {
            return this.Message;

        }


    }
      
    }

