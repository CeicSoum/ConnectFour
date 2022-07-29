using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectFour : MonoBehaviour {
 int playerTurn = 0, countOne = 1, countTwo = 1, countThree = 1, countFour = 1, countFive = 1, countSix = 1, countSeven = 1;
 public Text playerText;
 public Button btnOne, btnTwo, btnThree, btnFour, btnFive, btnSix, btnSeven;
 public Image oneOne, oneTwo, oneThree, oneFour, oneFive, oneSix;
 public Image twoOne, twoTwo, twoThree, twoFour, twoFive, twoSix;
 public Image threeOne, threeTwo, threeThree, threeFour, threeFive, threeSix;
 public Image fourOne, fourTwo, fourThree, fourFour, fourFive, fourSix;
 public Image fiveOne, fiveTwo, fiveThree, fiveFour, fiveFive, fiveSix;
 public Image sixOne, sixTwo, sixThree, sixFour, sixFive, sixSix;
 public Image sevenOne, sevenTwo, sevenThree, sevenFour, sevenFive, sevenSix;
 public Sprite invisible, chipRed, chipYellow;
 string[,] connect = new string[6, 7];
 Color blueText = new Color(0, 252, 50);
 
 public void Btn(int num) {
        Button one = btnOne.GetComponent<Button>(), two = btnTwo.GetComponent<Button>(), three = btnThree.GetComponent<Button>(), four = btnFour.GetComponent<Button>(), five = btnFive.GetComponent<Button>(), six = btnSix.GetComponent<Button>(), seven = btnSeven.GetComponent<Button>();
        if (playerTurn % 2 == 0) {

            switch (num) {
            case 1:

            if (countOne == 1) {
             oneOne.sprite = chipRed;
             connect[0, 0] = "red";
            }

            else if (countOne == 2) {
             oneTwo.sprite = chipRed;
             connect[1, 0] = "red";
            }

            else if (countOne == 3) {
             oneThree.sprite = chipRed;
             connect[2, 0] = "red";
            }

            else if (countOne == 4) {
             oneFour.sprite = chipRed;
             connect[3, 0] = "red";
            }

            else if (countOne == 5) {
             oneFive.sprite = chipRed;
             connect[4, 0] = "red";
            }

            else if (countOne == 6) {
             oneSix.sprite = chipRed;
             connect[5, 0] = "red";
             one.enabled = false;
            }

            countOne++;
            break;

            case 2:

            if (countTwo == 1) {
             twoOne.sprite = chipRed;
             connect[0, 1] = "red";
            }

            else if (countTwo == 2) {
             twoTwo.sprite = chipRed;
             connect[1, 1] = "red";
            }

            else if (countTwo == 3) {
             twoThree.sprite = chipRed;
             connect[2, 1] = "red";
            }

            else if (countTwo == 4) {
             twoFour.sprite = chipRed;
             connect[3, 1] = "red";
            }

            else if (countTwo == 5) {
             twoFive.sprite = chipRed;
             connect[4, 1] = "red";
            }

            else if (countTwo == 6) {
             twoSix.sprite = chipRed;
             connect[5, 1] = "red";
             two.enabled = false;
            }

            countTwo++;
            break;

            case 3:

            if (countThree == 1) {
             threeOne.sprite = chipRed;
             connect[0, 2] = "red";
            }

            else if (countThree == 2) {
             threeTwo.sprite = chipRed;
             connect[1, 2] = "red";
            }

            else if (countThree == 3) {
             threeThree.sprite = chipRed;
             connect[2, 2] = "red";
            }

            else if (countThree == 4) {
             threeFour.sprite = chipRed;
             connect[3, 2] = "red";
            }

            else if (countThree == 5) {
             threeFive.sprite = chipRed;
             connect[4, 2] = "red";
            }

            else if (countThree == 6) {
             threeSix.sprite = chipRed;
             connect[5, 2] = "red";
             three.enabled = false;
            }

            countThree++;
            break;

            case 4:

            if (countFour == 1) {
             fourOne.sprite = chipRed;
             connect[0, 3] = "red";
            }

            else if (countFour == 2) {
             fourTwo.sprite = chipRed;
             connect[1, 3] = "red";
            }

            else if (countFour == 3) {
             fourThree.sprite = chipRed;
             connect[2, 3] = "red";
            }

            else if (countFour == 4) {
             fourFour.sprite = chipRed;
             connect[3, 3] = "red";
            }

            else if (countFour == 5) {
             fourFive.sprite = chipRed;
             connect[4, 3] = "red";
            }

            else if (countFour == 6) {
             fourSix.sprite = chipRed;
             connect[5, 3] = "red";
             four.enabled = false;
            }

            countFour++;
            break;

            case 5:

            if (countFive == 1) {
             fiveOne.sprite = chipRed;
             connect[0, 4] = "red";
            }

            else if (countFive == 2) {
             fiveTwo.sprite = chipRed;
             connect[1, 4] = "red";
            }

            else if (countFive == 3) {
             fiveThree.sprite = chipRed;
             connect[2, 4] = "red";
            }

            else if (countFive == 4) {
             fiveFour.sprite = chipRed;
             connect[3, 4] = "red";
            }

            else if (countFive == 5) {
             fiveFive.sprite = chipRed;
             connect[4, 4] = "red";
            }

            else if (countFive == 6) {
             fiveSix.sprite = chipRed;
             connect[5, 4] = "red";
             five.enabled = false;
            }

            countFive++;
            break;

            case 6:

            if (countSix == 1) {
             sixOne.sprite = chipRed;
             connect[0, 5] = "red";
            }

            else if (countSix == 2) {
             sixTwo.sprite = chipRed;
             connect[1, 5] = "red";
            }

            else if (countSix == 3) {
             sixThree.sprite = chipRed;
             connect[2, 5] = "red";
            }

            else if (countSix == 4) {
             sixFour.sprite = chipRed;
             connect[3, 5] = "red";
            }

            else if (countSix == 5) {
             sixFive.sprite = chipRed;
             connect[4, 5] = "red";
            }

            else if (countSix == 6) {
             sixSix.sprite = chipRed;
             connect[5, 5] = "red";
             six.enabled = false;
            }

            countSix++;
            break;

            default:

            if (countSeven == 1) {
             sevenOne.sprite = chipRed;
             connect[0, 6] = "red";
            }

            else if (countSeven == 2) {
             sevenTwo.sprite = chipRed;
             connect[1, 6] = "red";
            }

            else if (countSeven == 3) {
             sevenThree.sprite = chipRed;
             connect[2, 6] = "red";
            }

            else if (countSeven == 4) {
             sevenFour.sprite = chipRed;
             connect[3, 6] = "red";
            }

            else if (countSeven == 5) {
             sevenFive.sprite = chipRed;
             connect[4, 6] = "red";
            }

            else if (countSeven == 6) {
             sevenSix.sprite = chipRed;
             connect[5, 6] = "red";
             seven.enabled = false;
            }

            countSeven++;
            break;           
            }

            playerTurn++;
            playerText.GetComponent<Text>().color = blueText;
            playerText.text = "Player 2 turn";
        }

        else if (playerTurn % 2 == 1) {

            switch (num) {
            case 1:

            if (countOne == 1) {
             oneOne.sprite = chipYellow;
             connect[0, 0] = "yellow";
            }

            else if (countOne == 2) {
             oneTwo.sprite = chipYellow;
             connect[1, 0] = "yellow";
            }

            else if (countOne == 3) {
             oneThree.sprite = chipYellow;
             connect[2, 0] = "yellow";
            }

            else if (countOne == 4) {
             oneFour.sprite = chipYellow;
             connect[3, 0] = "yellow";
            }

            else if (countOne == 5) {
             oneFive.sprite = chipYellow;
             connect[4, 0] = "yellow";
            }

            else if (countOne == 6) {
             oneSix.sprite = chipYellow;
             connect[5, 0] = "yellow";
             one.enabled = false;
            }

            countOne++;
            break;

            case 2:

            if (countTwo == 1) {
             twoOne.sprite = chipYellow;
             connect[0, 1] = "yellow";
            }

            else if (countTwo == 2) {
             twoTwo.sprite = chipYellow;
             connect[1, 1] = "yellow";
            }

            else if (countTwo == 3) {
             twoThree.sprite = chipYellow;
             connect[2, 1] = "yellow";
            }

            else if (countTwo == 4) {
             twoFour.sprite = chipYellow;
             connect[3, 1] = "yellow";
            }

            else if (countTwo == 5) {
             twoFive.sprite = chipYellow;
             connect[4, 1] = "yellow";
            }

            else if (countTwo == 6) {
             twoSix.sprite = chipYellow;
             connect[5, 1] = "yellow";
             two.enabled = false;
            }

            countTwo++;
            break;

            case 3:

            if (countThree == 1) {
             threeOne.sprite = chipYellow;
             connect[0, 2] = "yellow";
            }

            else if (countThree == 2) {
             threeTwo.sprite = chipYellow;
             connect[1, 2] = "yellow";
            }

            else if (countThree == 3) {
             threeThree.sprite = chipYellow;
             connect[2, 2] = "yellow";
            }

            else if (countThree == 4) {
             threeFour.sprite = chipYellow;
             connect[3, 2] = "yellow";
            }

            else if (countThree == 5) {
             threeFive.sprite = chipYellow;
             connect[4, 2] = "yellow";
            }

            else if (countThree == 6) {
             threeSix.sprite = chipYellow;
             connect[5, 2] = "yellow";
             three.enabled = false;
            }

            countThree++;
            break;

            case 4:

            if (countFour == 1) {
             fourOne.sprite = chipYellow;
             connect[0, 3] = "yellow";
            }

            else if (countFour == 2) {
             fourTwo.sprite = chipYellow;
             connect[1, 3] = "yellow";
            }

            else if (countFour == 3) {
             fourThree.sprite = chipYellow;
             connect[2, 3] = "yellow";
            }

            else if (countFour == 4) {
             fourFour.sprite = chipYellow;
             connect[3, 3] = "yellow";
            }

            else if (countFour == 5) {
             fourFive.sprite = chipYellow;
             connect[4, 3] = "yellow";
            }

            else if (countFour == 6) {
             fourSix.sprite = chipYellow;
             connect[5, 3] = "yellow";
             four.enabled = false;
            }

            countFour++;
            break;

            case 5:

            if (countFive == 1) {
             fiveOne.sprite = chipYellow;
             connect[0, 4] = "yellow";
            }

            else if (countFive == 2) {
             fiveTwo.sprite = chipYellow;
             connect[1, 4] = "yellow";
            }

            else if (countFive == 3) {
             fiveThree.sprite = chipYellow;
             connect[2, 4] = "yellow";
            }

            else if (countFive == 4) {
             fiveFour.sprite = chipYellow;
             connect[3, 4] = "yellow";
            }

            else if (countFive == 5) {
             fiveFive.sprite = chipYellow;
             connect[4, 4] = "yellow";
            }

            else if (countFive == 6) {
             fiveSix.sprite = chipYellow;
             connect[5, 4] = "yellow";
             five.enabled = false;
            }

            countFive++;
            break;

            case 6:

            if (countSix == 1) {
             sixOne.sprite = chipYellow;
             connect[0, 5] = "yellow";
            }

            else if (countSix == 2) {
             sixTwo.sprite = chipYellow;
             connect[1, 5] = "yellow";
            }

            else if (countSix == 3) {
             sixThree.sprite = chipYellow;
             connect[2, 5] = "yellow";
            }

            else if (countSix == 4) {
             sixFour.sprite = chipYellow;
             connect[3, 5] = "yellow";
            }

            else if (countSix == 5) {
             sixFive.sprite = chipYellow;
             connect[4, 5] = "yellow";
            }

            else if (countSix == 6) {
             sixSix.sprite = chipYellow;
             connect[5, 5] = "yellow";
             six.enabled = false;
            }

            countSix++;
            break;

            default:

            if (countSeven == 1) {
             sevenOne.sprite = chipYellow;
             connect[0, 6] = "yellow";
            }

            else if (countSeven == 2) {
             sevenTwo.sprite = chipYellow;
             connect[1, 6] = "yellow";
            }

            else if (countSeven == 3) {
             sevenThree.sprite = chipYellow;
             connect[2, 6] = "yellow";
            }

            else if (countSeven == 4) {
             sevenFour.sprite = chipYellow;
             connect[3, 6] = "yellow";
            }

            else if (countSeven == 5) {
             sevenFive.sprite = chipYellow;
             connect[4, 6] = "yellow";
            }

            else if (countSeven == 6) {
             sevenSix.sprite = chipYellow;
             connect[5, 6] = "yellow";
             seven.enabled = false;
            }

            countSeven++;
            break;           
            }

            playerTurn++;
            playerText.GetComponent<Text>().color = Color.red;
            playerText.text = "Player 1 turn";
        }
    }

}
