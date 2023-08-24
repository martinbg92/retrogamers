using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour

{
    public GameObject enemigo;
    public GameObject enemigo2;
    public GameObject cofre;
    public Vector3 spawnValues;
    public int hazardCount;
    public int hazard2Count;
    public int cofrescount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    private int score;
    public Text scoreText;
    public Text backmenu;
    string nameplayer;
    private string nombreprefs = "Nombre";
    private string scoreprefs = "score";


    /* private void OnEnable()
     {
         nameplayer = PlayerPrefs.GetString("name");
     }
    */
    private void Awake()
    {
        loaddata();
    }
    // Start is called before the first frame update
    void Start()   
    {
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    private IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {

            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Instantiate(enemigo, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);

            }

            for (int i = 0; i < hazard2Count; i++)
            {
                Vector3 spawnPosition2 = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), -120, spawnValues.z);
                Instantiate(enemigo2, spawnPosition2 , Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);

            }


            for (int i = 0; i < cofrescount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Instantiate(cofre, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);

            }

            

            yield return new WaitForSeconds(waveWait);
        
        }
        
    }

    public void AddScore (int value)

    {
        score += value;
        UpdateScore();

    }

    public void UpdateScore()
    {

        scoreText.text = nameplayer + " Puntuacion: " + score;
        backmenu.text = nameplayer + " Puntuacion: " + score;
    }

    private void OnDestroy()
    {

        savedata();
    }

    private void savedata()
    {
        PlayerPrefs.SetInt(scoreprefs, score);
    }

    private void loaddata()
    {
        nameplayer = PlayerPrefs.GetString(nombreprefs, "Carmen");
        score = PlayerPrefs.GetInt(scoreprefs, 20);
    }
}
