﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Problems;
namespace Codility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTennisTournament_Click(object sender, EventArgs e)
        {
            TennisTournament obj = new TennisTournament();
            var result1 = obj.solution(5, 3);
            var result2 = obj.solution(10, 3);
            var result3 = obj.solution(1, 3);
            var result4 = obj.solution(-1, -3);
            var result5 = obj.solution(40000, 40000);
        }

        private void btnSockSupply_Click(object sender, EventArgs e)
        {
            SocksSupply obj = new SocksSupply();
            var result1 = obj.solution(2, new int[] { 1, 2, 1, 1 }, new int[] { 1, 4, 3, 2, 4 });
        }

        private void btnBracketRotation_Click(object sender, EventArgs e)
        {
            Solution obj = new Solution();

            obj.BiggestPair = 0;
            var r = obj.solution(")()()(", 3);       //4 exp 6 (()())

            obj.BiggestPair = 0;
            var r5 = obj.solution(")))(((", 2);     //0 exp 4 )()()(

            obj.BiggestPair = 0;
            var r1 = obj.solution("()()",2);       //4
            
            obj.BiggestPair = 0;
            var r2 = obj.solution("(())()",2);     //6

            obj.BiggestPair = 0;
            var r3 = obj.solution("((())(()",2);   //4 exp 8

            obj.BiggestPair = 0;
            var r4 = obj.solution("((()))()",2);   //8 exp 8



            obj.BiggestPair = 0;
            var r6 = obj.solution("))(()(())))(())",2);     //8

        }

        private void btnLights_Click(object sender, EventArgs e)
        {
            WinterLighits.Solution obj = new WinterLighits.Solution();
            int x12 = obj.solution("6565kkhjkjhkjrkjrkjeiunnfkfjeeeji4ui4mekrjewlwrj3oi5iu54iu54i54op22343k4jksmfmdsdmfnccnllrppyoi5o3434545565676787865656565454353534343crggg454545454545476767676yuytttttttttttttt76766676787ytrtr5645499hdwc9plattrtv9568fjmvi348dkfn4204598rkrtnrrty095884721234567890qwert5434343445454545454545465656776767676767676767675654656565656565656565kkhjkjhkjrkjrkjeiunnfkfjeeeji4ui4mekrjewlwrj3oi5iu54iu54i54op22343k4jksmfmdsdmfnccnllrppyoi5o3434545565676787865656565454353534343crggg454545454545476767676yuytttttttttttttt76766676787ytrtr5645499hdwc9plattrtv9568fjmvi348dkfn4204598rkrtnrrty095884721234567890qwert5434343445454545454545465656776767676767676767675654656565656565656565kkhjkjhkjrkjrkjeiunnfkfjeeeji4ui4mekrjewlwrj3oi5iu54iu54i54op22343k4jksmfmdsdmfnccnllrppyoi5o3434545565676787865656565454353534343crggg454545454545476767676yuytttttttttttttt76766676787ytrtr5645499hdwc9plattrtv9568fjmvi348dkfn4204598rkrtnrrty095884721234567890qwert5434343445454545454545465656776767676767676767675654656565656565656565kkhjkjhkjrkjrkjeiunnfkfjeeeji4ui4mekrjewlwrj3oi5iu54iu54i54op22343k4jksmfmdsdmfnccnllrppyoi5o3434545565676787865656565454353534343crggg454545454545476767676yuytttttttttttttt76766676787ytrtr5645499hdwc9plattrtv9568fjmvi348dkfn4204598rkrtnrrty095884721234567890qwert5434343445454545454545465656776767676767676767675654656565656565656565kkhjkjhkjrkjrkjeiunnfkfjeeeji4ui4mekrjewlwrj3oi5iu54iu54i54op22343k4jksmfmdsdmfnccnllrppyoi5o3434545565676787865656565454353534343crggg454545454545476767676yuytttttttttttttt76766676787ytrtr5645499hdwc9plattrtv9568fjmvi348dkfn4204598rkrtnrrty095884721234567890qwert543434344545454545454546565677676767676767676767565465656565656565");
            int x11 = obj.solution("Thue-Morse");
            int x0 = obj.solution(txtWinterLights.Text.Trim());
            int x1 = obj.solution("00");
            int x2 = obj.solution("000"); //0,0,00,0,00,00,000
            int x3 = obj.solution("123");   //1,2,12,3,13,23,123
            int x4 = obj.solution("02002"); //0,2,02,0,00,20,020,0,00,20,020,00,000,200,0200,2,02,22,022,02,002,202,0202,02,002,202,0202,002,0002,2002,02002
        }

        private void btnChromium_Click(object sender, EventArgs e)
        {
            Chromium.Solution obj = new Chromium.Solution();
            Chromium2.Solution obj2 = new Chromium2.Solution();
            int[] arr1 = new int[] { 13, 2, 5 };
            int result = obj.solution(arr1); // 7
            int result01 = obj2.solution(arr1); // 7


            int[] arr2 = new int[] { 4, 6, 2, 1, 5 };
            int result1 = obj.solution(arr2); // 23
            int result12 = obj2.solution(arr2); // 23

            int[] arr3 = new int[] {13,2,5,7 };
            int result2 = obj.solution(arr3); // 13
            int result21 = obj2.solution(arr3); // 13

            int[] arr4 = new int[] { 3,4,65,8,2 };
            int result3 = obj.solution(arr4); // 15
            int result31 = obj2.solution(arr4); // 15

            int[] arr5 = new int[] {5,4,8,9,1,6,2};
            int result4 = obj.solution(arr5); // 49
            int result41 = obj2.solution(arr5); // 49


            int[] arr6 = new int[] { 5, 4,33434343,56,689,453345, 8, 9,97878,2342,23,5656879, 1, 6,76765,32211,45478,56786789,464335,55,6767,332,58790,345688004,454332,67676,6767674,6666,322222,5656, 2 };
            //int result4 = obj.solution(arr5);
            int result61 = obj2.solution(arr6);
        }
    }
}