using UnityEngine;
using System.Collections;

public class AppContext
{
    private int _pointToWin = 1;
    private float _timePlay = 30;
    private float _bomp = 0;
    private int points = 0;
    private static AppContext instance;
    private float localScale;
    private int _level1 = 1;
    private int _level2 = 2;
    private int _level3 = 2;
    private int _level4 = 3;
    private float scaleRatio;
    private float screenbase = 1366;
    private bool isbaseGame = false;
    private int crrBaseLevel = 1;
    private bool nextScrIsHigh = false;
    private bool is2ndBase = false;
	private bool canGoHighitScr = false;
    public string Name;
    public int Score;
    public string TopScore;
    public ArrayList ArrayListTop5;

    

    public bool Is2NdBase
    {
        get { return is2ndBase; }
        set { is2ndBase = value; }
    }

    public static AppContext Current
    {
        get { return instance ?? (instance = new AppContext()); }
    }

    private AppContext()
    {
        LoadDataConfig();
        CalcScaleRatio();
    }
    public bool NextScrIsHigh
    {
        get { return nextScrIsHigh; }
        set { nextScrIsHigh = value; }
    }

    public int CrrBaseLevel
    {
        get { return crrBaseLevel; }
        set { crrBaseLevel = value; }
    }

    public int PointToWin
    {
        get { return _pointToWin; }
        set { _pointToWin = value; }
    }

    public float TimePlay
    {
        get { return _timePlay; }
        set { _timePlay = value; }
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    public int Level1
    {
        get { return _level1; }
        set { _level1 = value; }
    }

    public int Level2
    {
        get { return _level2; }
        set { _level2 = value; }
    }

    public int Level3
    {
        get { return _level3; }
        set { _level3 = value; }
    }

    public int Level4
    {
        get { return _level4; }
        set { _level4 = value; }
    }

    public float LocalScale
    {
        get { return localScale; }
        set { localScale = value; }
    }

    public float ScaleRatio
    {
        get { return scaleRatio; }
        set { scaleRatio = value; }
    }

    public float Bomp
    {
        get { return _bomp; }
        set { _bomp = value; }
    }

    public bool IsbaseGame
    {
        get { return isbaseGame; }
        set { isbaseGame = value; }
    }

    private void LoadDataConfig()
    {
//        Debug.Log(Application.dataPath);
        if (System.IO.File.Exists(Application.dataPath + "/AppConfig.txt"))
        {
            string[] Data = System.IO.File.ReadAllLines(Application.dataPath + "/AppConfig.txt");
            string pointToWin = Data[0].Split('=')[1];
            string timePlay = Data[1].Split('=')[1];
            string level1 = Data[2].Split('=')[1];
            string level2 = Data[3].Split('=')[1];
            string level3 = Data[4].Split('=')[1];
            string level4 = Data[5].Split('=')[1];
            _pointToWin = int.Parse(pointToWin);
            _timePlay = int.Parse(timePlay);
            Level1 = int.Parse(level1);
            Level2 = int.Parse(level2);
            Level3 = int.Parse(level3);
            Level4 = int.Parse(level4);
        }
    }

    private void CalcScaleRatio()
    {
        ScaleRatio = Screen.width/screenbase;
    }

	public bool CanGoHighitScr {
		get {
			return canGoHighitScr;
		}
		set {
			canGoHighitScr = value;
		}
	}
}
