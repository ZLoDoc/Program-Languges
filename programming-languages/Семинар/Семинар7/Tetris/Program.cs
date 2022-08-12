using System;

namespace Tetris {
    class Program {
        int[][] arr;
        static void Main(string[] args) {
            Program ro = new Program();
            ro.program();
            Console.ReadKey();
        }

        void program() {
            arr = new int[3][];
            arr[0] = new int[] { 1, 1, 1 };
            arr[1] = new int[] { 0, 1, 0 };
            arr[2] = new int[] { 0, 0, 0 };

            while (true){
                var input = Console.ReadKey();
                switch (input.Key) {
                    case ConsoleKey.A:
                        ArrReverseMinus();
                        break;
                    case ConsoleKey.D:
                        ArrReversePlus();
                        break;
                }
                for (int i = 0; i < arr.Length; i++) {
                    for (int j = 0; j < arr.Length; j++) {
                        Console.Write($"{arr[i][j],5}");
                    }
                    Console.WriteLine("");
                }
            }
        }
        void ArrReversePlus() {
            int[][] tempparseX = new int[3][], tempparseY = new int[3][];
            for (int i = 0; i < arr.Length; i++) {
                tempparseX[i] = arr[i];
            }
            for (int i = 0; i < 3; i++) {
                tempparseY[i] = new int[3];
                for (int j = 0; j < tempparseY[i].Length; j++) {
                    tempparseY[i][j] = tempparseX[j][i];
                }
            }
            for (int i = 0; i < 3; i++) {
                Array.Reverse(tempparseY[i]);
                arr[i] = tempparseY[i];
            }
        }
        void ArrReverseMinus() {
            int[][] tempparseX = new int[3][], tempparseY = new int[3][];
            for (int i = 0; i < arr.Length; i++) {
                tempparseX[i] = arr[i];
            }
            for (int i = 0; i < 3; i++) {
                tempparseY[i] = new int[3];
                for (int j = 0; j < tempparseY[i].Length; j++) {
                    tempparseY[i][j] = tempparseX[j][i];
                }
            }
            for (int i = 0; i < 3; i++) {
                arr[i] = tempparseY[i];//здесь не поворачиваю
            }
        }
    }
}
