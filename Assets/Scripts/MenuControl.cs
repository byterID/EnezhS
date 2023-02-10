using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public ParticleSystem GrParticles;

    public GameObject MainScreen;
    public GameObject StartScreen;
    public GameObject TutorialScreen;
    public GameObject EndCardScreen;
    public GameObject TestScreen;
    public GameObject FailScreen;
    public GameObject EndOfGameScreen;

    public GameObject EndCardButton;

    public GameObject[] Card;
    public GameObject[] ButForw;
    public GameObject[] ButBack;
    public GameObject[] TestCard;
    int y = 0;
    public void Start()
    {
        
    }
    public void StartGame()
    {
        GrParticles.Play();
        MainScreen.SetActive(true);
        StartScreen.SetActive(false);
    }
    public void StartTutorial()
    {
        MainScreen.SetActive(false);
        TutorialScreen.SetActive(true);
        EndCardButton.SetActive(false);
    }
    public void EndCards()
    {
        TutorialScreen.SetActive(false);
        EndCardScreen.SetActive(true);
        GrParticles.Play();
        EndCardButton.SetActive(false);
    }
    public void GoMainMenu()
    {
        EndCardScreen.SetActive(false);
        MainScreen.SetActive(true);
        TestScreen.SetActive(false);
        EndOfGameScreen.SetActive(false);
        FailScreen.SetActive(false);
    }
    public void StartTest()
    {
        EndCardScreen.SetActive(false);
        TestScreen.SetActive(true);
        TestCard[0].SetActive(true);
    }

    public void TurnCard()
    {
        y += 180;
        Card[0].transform.localRotation = Quaternion.Euler(0, y, 0);
        
    }
    public void TurnCard2()
    {
        y += 180;
        Card[1].transform.localRotation = Quaternion.Euler(0, y, 0);
    }
    public void TurnCard3()
    {
        y += 180;
        Card[2].transform.localRotation = Quaternion.Euler(0, y, 0);
    }
    public void TurnCard4()
    {
        y += 180;
        Card[3].transform.localRotation = Quaternion.Euler(0, y, 0);
    }
    public void TurnCard5()
    {
        y += 180;
        Card[4].transform.localRotation = Quaternion.Euler(0, y, 0);
    }
    public void TurnCard6()
    {
        y += 180;
        Card[5].transform.localRotation = Quaternion.Euler(0, y, 0);

    }
    public void TurnCard7()
    {
        y += 180;
        Card[6].transform.localRotation = Quaternion.Euler(0, y, 0);

    }
    public void TurnCard8()
    {
        y += 180;
        Card[7].transform.localRotation = Quaternion.Euler(0, y, 0);

    }
    public void TurnCard9()
    {
        y += 180;
        Card[8].transform.localRotation = Quaternion.Euler(0, y, 0);

    }
    /// <summary>
    /// ////////////////////////////боепед
    /// </summary>
    public void Next1()
    {
        Card[0].SetActive(false);
        Card[1].SetActive(true);
        ButForw[0].SetActive(false);
        ButForw[1].SetActive(true);
        ButBack[0].SetActive(true);
    }
    public void Next2()
    {
        Card[1].SetActive(false);
        Card[2].SetActive(true);
        ButForw[1].SetActive(false);
        ButBack[0].SetActive(false);
        ButForw[2].SetActive(true);
        ButBack[1].SetActive(true);
    }
    public void Next3()
    {
        Card[2].SetActive(false);
        Card[3].SetActive(true);
        ButForw[2].SetActive(false);
        ButBack[1].SetActive(false);
        ButForw[3].SetActive(true);
        ButBack[2].SetActive(true);
    }
    public void Next4()
    {
        Card[3].SetActive(false);
        Card[4].SetActive(true);
        ButForw[3].SetActive(false);
        ButBack[2].SetActive(false);
        ButForw[4].SetActive(true);
        ButBack[3].SetActive(true);
    }
    public void Next5()
    {
        Card[4].SetActive(false);
        Card[5].SetActive(true);
        ButForw[4].SetActive(false);
        ButBack[3].SetActive(false);
        ButForw[5].SetActive(true);
        ButBack[4].SetActive(true);
    }
    public void Next6()
    {
        Card[5].SetActive(false);
        Card[6].SetActive(true);
        ButForw[5].SetActive(false);
        ButBack[4].SetActive(false);
        ButForw[6].SetActive(true);
        ButBack[5].SetActive(true);
    }
    public void Next7()
    {
        Card[6].SetActive(false);
        Card[7].SetActive(true);
        ButForw[6].SetActive(false);
        ButBack[5].SetActive(false);
        ButForw[7].SetActive(true);
        ButBack[6].SetActive(true);
    }
    public void Next8()
    {
        Card[7].SetActive(false);
        Card[8].SetActive(true);
        ButForw[7].SetActive(false);
        ButBack[6].SetActive(false);
        ButBack[7].SetActive(true);
        EndCardButton.SetActive(true);
    }
    /// <summary>
    /// //////////////////////////////////мюгюд
    /// </summary>
    public void Back1()
    {
        Card[0].SetActive(true);
        Card[1].SetActive(false);
        ButForw[0].SetActive(true);
        ButForw[1].SetActive(false);
        ButBack[0].SetActive(false);
    }
    public void Back2()
    {
        Card[1].SetActive(true);
        Card[2].SetActive(false);
        ButForw[1].SetActive(true);
        ButBack[0].SetActive(true);
        ButForw[2].SetActive(false);
        ButBack[1].SetActive(false);
    }
    public void Back3()
    {
        Card[2].SetActive(true);
        Card[3].SetActive(false);
        ButForw[2].SetActive(true);
        ButBack[1].SetActive(true);
        ButForw[3].SetActive(false);
        ButBack[2].SetActive(false);
    }
    public void Back4()
    {
        Card[3].SetActive(true);
        Card[4].SetActive(false);
        ButForw[3].SetActive(true);
        ButBack[2].SetActive(true);
        ButForw[4].SetActive(false);
        ButBack[3].SetActive(false);
    }
    public void Back5()
    {
        Card[4].SetActive(true);
        Card[5].SetActive(false);
        ButForw[4].SetActive(true);
        ButBack[3].SetActive(true);
        ButForw[5].SetActive(false);
        ButBack[4].SetActive(false);
    }
    public void Back6()
    {
        Card[5].SetActive(true);
        Card[6].SetActive(false);
        ButForw[5].SetActive(true);
        ButBack[4].SetActive(true);
        ButForw[6].SetActive(false);
        ButBack[5].SetActive(false);
    }
    public void Back7()
    {
        Card[6].SetActive(true);
        Card[7].SetActive(false);
        ButForw[6].SetActive(true);
        ButBack[5].SetActive(true);
        ButForw[7].SetActive(false);
        ButBack[6].SetActive(false);
    }
    public void Back8()
    {
        Card[7].SetActive(true);
        Card[8].SetActive(false);
        ButForw[7].SetActive(true);
        ButBack[6].SetActive(true);
        ButBack[7].SetActive(false);
        EndCardButton.SetActive(false);
    }
    
    ////////////////////////////////////////////////////////////реяр
    
    public void TestFail()
    {
        TestCard[0].SetActive(false);
        TestCard[1].SetActive(false);
        TestCard[2].SetActive(false);
        TestCard[3].SetActive(false);
        TestCard[4].SetActive(false);
        TestCard[5].SetActive(false);
        TestScreen.SetActive(false);
        FailScreen.SetActive(true);
    }

    public void TestNext1()
    {
        TestCard[0].SetActive(false);
        TestCard[1].SetActive(true);
    }
    public void TestNext2()
    {
        TestCard[1].SetActive(false);
        TestCard[2].SetActive(true);
    }
    public void TestNext3()
    {
        TestCard[2].SetActive(false);
        TestCard[3].SetActive(true);
    }
    public void TestNext4()
    {
        TestCard[3].SetActive(false);
        TestCard[4].SetActive(true);
    }
    public void TestNext5()
    {
        TestCard[4].SetActive(false);
        TestCard[5].SetActive(true);
    }

    public void TestFinish()
    {
        TestScreen.SetActive(false);
        TestCard[5].SetActive(false);
        EndOfGameScreen.SetActive(true);
        GrParticles.Play();
    }

    public void RestartTest()
    {
        TestCard[0].SetActive(true);
        FailScreen.SetActive(false);
        TestScreen.SetActive(true);
    }
}
