using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ObjectLifeCycle : MonoBehaviour
{
    // Awake: 해당 스크립트가 최초로 활성화 될 때 호출되는 함수 (게임 실행 시 한 번만 호출됨)
    private void Awake()
    {
        Debug.Log("Awake func is Called");
    }

    // OnEnable: 활성화 될 때마다 호출되는 함수
    private void OnEnable()
    {
        Debug.Log("OnEnable func is Called");
    }

    // Reset: 게임 내부에서가 아닌 Inspector에서 컴포넌트를 초기화 할 때 동작하는 함수 (혹은 스크립트를 컴포넌트로 추가할 때도 동작)
    private void Reset()
    {
        Debug.Log("Reset func is Called");
    }

    // OnValidate: 에디터에서 스크립트 또는 해당 요소가 수정될 때 동작하는 함수
    private void OnValidate()
    {
        Debug.Log("OnValidate func is Called");
    }

    // Start: 해당 스크립트가 최초로 활성화 될 때 호출되는 함수 (게임 실행 시 한 번만 호출됨, Awake 보다 느리게 동작)
    private void Start()
    {
        Debug.Log("Start func is Called");
    }

    // FixedUpdate: 고정된 속도로 호출되며, 프레임에 따라 여러 번 호출되거나, 한 번도 호출되지 않을 수 있는 함수 (모든 물리 계산 및 업데이트를 FixedUpdate 이후 계산하게 됨)
    private void FixedUpdate()
    {
        
    }

    /**

    Internal Animation Update: 애니메이션 상태를 관련하는 함수 호출됨

    */

    // OnTriggerXXX: 물리적인 충돌이 비활성화되어 있는 상태에서 Collider 간의 충돌 계산을 제어하는 함수
    private void OnTriggerEnter(Collider collider) 
    {
        
    }

    private void OnTriggerStay(Collider collider) 
    {
        
    }

    private void OnTriggerExit(Collider collider) 
    {
        
    }

    // OnColliderXXX: 물리적인 충돌이 활성화되어 있는 상태에서 Collider 간의 충돌 계산을 제어하는 함수
    private void OnCollisionEnter(Collision collision) 
    {
        
    }

    private void OnCollisionStay(Collision collision) 
    {
        
    }

    private void OnCollisionExit(Collision collision) 
    {
        
    }

    // yield WaitForFixedUpdate: 모든 FixedUpdate 함수가 호출된 이후에 동작하는 함수
    private IEnumerator WaitForFixedUpdateTime()
    {
        yield return new WaitForFixedUpdate();
    }

    // OnMouseXXX: 마우스로 들어오는 입력을 제어하는 함수
    private void OnMouseEnter() 
    {
        
    }

    private void OnMouseDown() 
    {
        
    }
    
    private void OnMouseOver() 
    {
        
    }

    private void OnMouseDrag() 
    {
        
    }

    private void OnMouseUp()
    {
        
    }

    private void OnMouseUpAsButton() 
    {
        
    }
    
    // Update: 매 프레임 당 한 번 호출되는 함수
    private void Update()
    {
        
    }

    private IEnumerator NullTime()
    {
        yield return null;
    }

    private IEnumerator WaitForSecondsTime()
    {
        yield return new WaitForSeconds(0.0f);
    }

    private IEnumerator WWWTime()
    {
        UnityWebRequest www = UnityWebRequest.Get("www.google.com");
        yield return www.SendWebRequest();
    }

    private IEnumerator StartCoroutineTime()
    {
        yield return StartCoroutine("CoroutineFunction");
    }

    /**

    Internal Animation Update: 애니메이션 상태를 관련하는 함수 호출됨

    */

    // LateUpdate: 모든 Update 함수가 종료된 이후 호출되며, Update의 계산은 LateUpdate 함수가 호출될 때 종료됨
    private void LateUpdate()
    {

    }

    private void OnPreCull()
    {

    }

    private void OnWillRenderObject() 
    {
        
    }

    private void OnBecameVisible() 
    {
        
    }

    private void OnBecameInvisible() 
    {
        
    }

    private void OnPreRender() 
    {
        
    }

    private void OnRenderObject() 
    {
        
    }

    private void OnPostRender() 
    {
        
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest) 
    {
        
    }

    private void OnDrawGizmos() 
    {
        
    }

    private void OnGUI() 
    {
        
    }

    private IEnumerator WaitForEndOfFrameTime()
    {
        yield return new WaitForEndOfFrame();
    }

    private void OnApplicationPause(bool pauseStatus) 
    {
        if(pauseStatus)
        {
            Debug.Log("일시 정지됨");
        }
        else
        {
            Debug.Log("일시 정지 해제됨");
        } 
    }

    private void OnApplicationQuit() 
    {
        
    }

    // OnDisable: 비활성화 될 때마다 호출되는 함수
    private void OnDisable()
    {
        Debug.Log("OnDisable func is Called");
    }

    private void OnDestroy()
    {
        
    }
}
