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
        int INPUT_TYPE = 3; //입력 데이터중 한 쌍이 되는 데이터의 갯수
        
        //입력되는 데이터
        double[] data = null;
        double[,] inputData = null;

        //이미지
        Image image = null;

        public InputData( )
        {

        }

        public InputData(Image image)
        {
            this.image = image;
            Init();

          
        }


        private void Init()
        {
            Bitmap tempBitmap = new Bitmap(image);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    if(tempBitmap.GetPixel(x,y).A != 0){

            }
                }
            }

            inputData = new double[data.Length / INPUT_TYPE, INPUT_TYPE];

        }

        public void Run() //입력된 데이터를 x, y구분하여 input_data에 2차원배열로 대입한다.
        {
            int count = 0;
            for (int i = 0; i < data.Length / INPUT_TYPE; i++)
            {
                for (int k = 0; k < INPUT_TYPE; k++)
                {
                    inputData[i, k] = data[count];
                    count++;
                }
            }
        }

        public double[,] GetinputData() //배열 inputData를 배열 temp에 통째로 복사 후 temp를 return함 (보안)
        {
            double[,] temp = (double[,])inputData.Clone();
            //= new int[inputData.GetLength(0), inputData.GetLength(1)];
            return temp;



        }


    }
}
