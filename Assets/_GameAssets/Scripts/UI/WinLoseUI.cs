using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject _blackBackroundObject;
    [SerializeField] private GameObject _winPopup;

    [SerializeField] private GameObject _loosePopup;

    [Header("Settings")]
    [SerializeField] private float _animationDuration = 0.3f;

    private Image _blackBackroudImage;
    private RectTransform _winPopupTransform;
    private RectTransform _loosePopupTransform;

    private void Awake()
    {
        _blackBackroudImage = _blackBackroundObject.GetComponent<Image>();
        _winPopupTransform = _winPopup.GetComponent<RectTransform>();
        _loosePopupTransform = _loosePopup.GetComponent<RectTransform>();
    }

    public void OnGameWin()
    {
        _blackBackroundObject.SetActive(true);
        _winPopup.SetActive(true);

        _blackBackroudImage.DOFade(0.8f, _animationDuration).SetEase(Ease.Linear);
        _winPopupTransform.DOScale(1.5f, _animationDuration).SetEase(Ease.OutBack);
    }

    public void OnGameLoose()
    {
        _blackBackroundObject.SetActive(true);
        _loosePopup.SetActive(true);

        _blackBackroudImage.DOFade(0.8f, _animationDuration).SetEase(Ease.Linear);
        _loosePopupTransform.DOScale(1.5f, _animationDuration).SetEase(Ease.OutBack);
    }
}