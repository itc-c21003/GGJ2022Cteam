using System.Collections;
using UnityEngine;

public class ChangeActiveButton : MonoBehaviour
{
    public bool m_isSwitch;
    public bool m_forPhysical = true;
    public bool m_forSpiritual = false;
    [SerializeField] Component m_targetComponent;
    IHasActive targetComponent = null;
    IHasActive TargetComponent
    {
        get
        {
            if (targetComponent == null)
            {
                targetComponent = m_targetComponent.GetComponent<IHasActive>();
            }
            return targetComponent;
        }
    }
    [SerializeField] bool state = false;
    bool ButtonState
    {
        get
        {
            return state;
        }
    }

    private void Start()
    {
        TargetComponent.IsActive = state;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((m_forPhysical && collision.tag == "Player") || (m_forSpiritual && collision.tag == "Ghost"))
        {
            state = !state;
            TargetComponent.IsActive = state;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!m_isSwitch && ((m_forPhysical && collision.tag == "Player") || (m_forSpiritual && collision.tag == "Ghost")))
        {
            state = !state;
            TargetComponent.IsActive = state;
        }
    }
}