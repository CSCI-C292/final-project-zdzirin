using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelUI : MonoBehaviour
{

    [SerializeField] RuntimeData _runtimeData;
    private Player _player;
    private TextMeshProUGUI _jumpNum;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        TextMeshProUGUI levelText = transform.Find("Level Text").gameObject.GetComponent<TextMeshProUGUI>();
        levelText.text = _runtimeData._levelName;
        _jumpNum = transform.Find("Jump Num").gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _jumpNum.text = _player.GetTotalJumps().ToString();
    }
}
