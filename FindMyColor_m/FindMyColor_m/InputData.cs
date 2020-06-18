using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
/*
 * 2020.06.12
 * 입력데이터를 처리하는 클래스 
 * 데이터 입력방식은 향후 수정
 * x, y 쌍으로 된 데이터가 1차원 배열로 늘어져있음
 * 
 */
namespace FindMyColor_m
{
    class InputData
    {
        //정적변수
        int INPUT_TYPE = 3; //입력 데이터중 한 쌍이 되는 데이터의 갯수
        
        // 데이터
        double[] data = null;
        double[,] inputData = null;

        SetForm setForm = null;

        List<Color> inputColor = null;
        Image image = null;

        public InputData( )
        {

        }

        public InputData(SetForm setForm)
        {
            this.setForm = setForm;
            image = setForm.pictureBox1.Image;
            inputColor = new List<Color>();
        }


        public double[,] Run() //입력된 데이터를 x, y구분하여 input_data에 2차원배열로 대입한다.
        {
            Bitmap tempBitmap = new Bitmap(image);
            List<double> tempList = new List<double>();

            int count = 0;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = tempBitmap.GetPixel(x, y);
                    if (color.A != 0)
                    {
                        inputColor.Add(color);
                        double[] tempcmyk = setForm.RgbToCmyk(color);
                        double[] tempHsl = setForm.RgbToHsl(color);

                        tempList.Add(tempHsl[2] *100);
                        tempList.Add(tempHsl[1] * 100);

                        tempList.Add(tempcmyk[2] * 100);

                        count++;

                    }
                }
            }

            data = new double[count];

            for (int i = 0; i < count; i++)
            {
                data[i] = tempList[i];
            }

            inputData = new double[data.Length / INPUT_TYPE, INPUT_TYPE];

            
            int index = 0;
            for (int i = 0; i < data.Length / INPUT_TYPE; i++)
            {
                for (int k = 0; k < INPUT_TYPE; k++)
                {
                    inputData[i, k] = data[index];
                    index++;
                }
            }

            setForm.selectedColor = inputColor;

            return inputData;

        }

    }
}
