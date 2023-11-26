namespace Lab
{
    internal class ComplexNumber
    {
        private decimal real_num;
        public decimal Real_num
        {
            get
            {
                return real_num;
            }
        }
        private decimal imaginary_num;
        public decimal Imaginary_num
        {
            get
            {
                return imaginary_num;
            }
        }
        public ComplexNumber(decimal real_num, decimal imaginary_num) 
        { 
            this.real_num = real_num;
            this.imaginary_num = imaginary_num;
        }
        static public ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.real_num + num2.real_num, num1.imaginary_num + num2.imaginary_num);
        }
        static public ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.real_num - num2.real_num, num1.imaginary_num - num2.imaginary_num);
        }
        static public bool operator ==(ComplexNumber num1, ComplexNumber num2)
        {
            if(num1.real_num == num2.real_num && num1.imaginary_num == num2.imaginary_num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator !=(ComplexNumber num1, ComplexNumber num2)
        {
            return !(num1 == num2);
        }
        public override string ToString()
        {
            return $"Реальная часть: {real_num}, Мнимая часть: {imaginary_num}";
        }
    }
}
