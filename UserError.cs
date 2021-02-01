using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    abstract class UserError
    {

        public string Str = "Some text";

        public virtual string UEMessage(string str)
        {
            return str;
        }

        public virtual string UEMessage()
        {
            return this.Str;
        }
      
    }

    class NumericInputError: UserError

    {

       

        public override string UEMessage(string str = "You tried to use a numeric input in a text only field. This fired an error!")
        {
            return str;
        }

        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }






    }




    class TextInputError : UserError
    {
       

        public override string UEMessage(string str = "You tried to use a text input in anumericonly field. This fired an error!")
        {
            return str;
        }

        public override string UEMessage()
        {
            return "You tried to use a text input in anumericonly field. This fired an error!";
        }



    }

    class Cutom1 : UserError
    {
        public override string UEMessage()
        {
            return "String1!";
        }

    }
    class Cutom2 : UserError
    {
        public override string UEMessage()
        {
            return "String2!";
        }

    }
    class Cutom3 : UserError
    {
        public override string UEMessage()
        {
            return "String3!";
        }

    }

}

