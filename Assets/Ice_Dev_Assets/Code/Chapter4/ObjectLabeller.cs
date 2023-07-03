using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace IceZK_DEV
{
public class ObjectLabeller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected string m_Label = "";
    [SerializeField] protected Color m_Colour = Color.black;
        
    [SerializeField] protected Vector3 m_TextOffset = Vector3.zero;
        
    private Canvas m_Canvas;
    private RectTransform m_RectTransform;
        
    private Text m_TextLabel;
    
    public string Label
    { 
        get 
        { 
            return m_TextLabel.text;
        } 
         set 
         { 
             m_Label = value; 
             m_TextLabel.text = m_Label; 
         } 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Always face camera
        m_Canvas.transform.rotation = Quaternion.LookRotation( m_Canvas.transform.
            position - Camera.main.transform.position );
    }

    private void Awake()
    {
        var canvasGo = new GameObject("Canvas"); 
        canvasGo.transform.SetParent(transform); 
        m_Canvas = canvasGo.AddComponent <Canvas >();
        
        m_Canvas.renderMode = RenderMode.WorldSpace;
        
        canvasGo.AddComponent <CanvasScaler >(); 
        m_RectTransform = canvasGo.GetComponent <RectTransform >(); 
        m_RectTransform.localPosition = Vector3.zero;
        
        var textGo = new GameObject("TextLabel"); 
        textGo.transform.SetParent(canvasGo.transform); 
        m_TextLabel = textGo.AddComponent <Text>(); 
        m_TextLabel.transform.localPosition = Vector3.up + m_TextOffset; 
        m_TextLabel.transform.localScale = new Vector3(0.02f,0.02f,0.02f); 
        m_TextLabel.alignment = TextAnchor.MiddleCenter;
        m_TextLabel.text = m_Label == "" ? gameObject.name : m_Label; 
        m_TextLabel.font = Font.CreateDynamicFontFromOSFont("Arial",16); 
        m_TextLabel.color = m_Colour;
        
        m_Label = m_TextLabel.text;
    }
}
}


