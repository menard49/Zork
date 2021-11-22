using UnityEngine;
using Zork;

public class GameManager: MonoBehaviour
{
    void Awake ()
    {
       TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        Game.Start(gameJsonAsset.text, InputService, OutputService);
        //Game.Instance.CommandManager.PerformCommand(Game.Instance, "LOOK");
        //Game.Start(gameJsonAsset.text, Output, Input);
    }

    void Start()
    {
        
    }

  // void Update()
  // {
  //     if (Input.GetKey(KeyCode.Return))
  //     {
  //         InputService.ProcessInput();
  //     }
  // }

    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;
    
}
