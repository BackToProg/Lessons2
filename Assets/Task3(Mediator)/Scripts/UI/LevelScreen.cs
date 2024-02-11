using Task3_Mediator_.Scripts.Mediator;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelScreen : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private TextMeshProUGUI _levelText;

    private GameplayMediator _mediator;
    
    public void Initialize(GameplayMediator mediator) => _mediator = mediator;

    private void Awake()
    {
        HideRestartButton();
    }

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(OnRestartButtonClick);
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
    }

    public void ShowRestartButton() => _restartButton.gameObject.SetActive(true);

    public void HideRestartButton() => _restartButton.gameObject.SetActive(false);

    public void ChangeHealthText(int healthValue) => _healthText.text = healthValue.ToString();
    
    public void ChangeLevelText(int levelValue) => _levelText.text = levelValue.ToString();

    public void ResetDate(int healthValue, int levelValue)
    {
        _healthText.text = healthValue.ToString();
        _levelText.text = levelValue.ToString();
    }
    
    private void OnRestartButtonClick() => _mediator.RestartLevel();
}
