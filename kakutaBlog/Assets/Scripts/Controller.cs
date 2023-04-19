using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Controller : MonoBehaviour {
    [SerializeField] float runspeed = 3f; //モデルの移動に関する変数定義
    [SerializeField] float rotateSpeed = 10f;
    private Animator animator; //アニメータ、PhotonViewに関する変数
    void Start() {
        animator = gameObject.GetComponent<Animator>(); //animatorの取得
    }
    void Update() { 
        //各種キー操作とアニメーション制御
        if (Input.GetKeyDown(KeyCode.Space) &&
            !animator.GetCurrentAnimatorStateInfo(0).IsName("jump") &&
            !animator.IsInTransition(0)) { //Spaceキーでジャンプ
            animator.SetTrigger("jump");
        }
        if (Input.GetKey(KeyCode.W)) { //Wキーで前進
            animator.SetFloat("speed", runspeed);
            animator.transform.position +=
                animator.transform.forward * Time.deltaTime * runspeed;
        }
        if (Input.GetKeyUp(KeyCode.W)) { //押し終わったらストップ
            animator.SetFloat("speed", 0f);
        }
        if (Input.GetKey(KeyCode.A)) { //Aキーで左回転
            animator.transform.Rotate(0f, -0.10f * rotateSpeed, 0f);
        }
        if (Input.GetKey(KeyCode.D)) { //Dキーで右回転
            animator.transform.Rotate(0f, 0.10f * rotateSpeed, 0f);
        }
    }
}