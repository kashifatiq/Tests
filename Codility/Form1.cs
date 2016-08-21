using System;
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
    }
}