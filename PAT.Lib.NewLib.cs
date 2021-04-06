using System;
using System.Collections.Generic;
using System.Text;
using PAT.Common.Classes.Expressions.ExpressionClass;

//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    public class Player : ExpressionValue
    {    	 
    	public int row;
    	public int col;
    	public int ball_ownership;
    	public int team;
    	
        public Player()
        {
            row = 0;
            col = 0;
            ball_ownership = 0;
            team = 0;
        }
        
        public Player(int init_row, int init_col, int init_ball_ownership, int init_team)
        {
        	row = init_row;
        	col = init_col;
        	ball_ownership = init_ball_ownership;
        	team = init_team;
        }

        public void setRow(int num) {
        	this.row = num;
        }
        
        public int getRow() {
        	return this.row;
        }
        
        public void setCol(int num) {
        	this.col = num;
        }
        
        public int getCol() {
        	return this.col;
        }
        
        public void setBall(int num) {
        	this.ball_ownership = num;
        }
        
        public int getBall() {
        	return this.ball_ownership;
        }
        
        public void setTeam(int num) {
        	this.team = num;
        }
        
        public int getTeam() {
        	return this.team;
        }
        
        public override string ToString() {
            string returnString = "";
            returnString += row + "," + col + "," + ball_ownership + "," + team;
            return returnString;
        }
		
		public override ExpressionValue GetClone() {
            return new Player(row, col, ball_ownership, team);
        }
        
		public override string ExpressionID {
           get {
               string returnString = "";
               returnString += row + "," + col + "," + ball_ownership + "," + team;
               return returnString;
           }
        }
    }
}
