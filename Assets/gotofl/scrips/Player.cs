using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using Spine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField]
    private string testAnimationName0;
    [SerializeField]
    private MeshRenderer mesh;

  
    private SkeletonAnimation skeletonAnimation = default;
    private Spine.AnimationState spineAnimationState = default;

    void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();
        mesh = GetComponent<MeshRenderer>();
        spineAnimationState = skeletonAnimation.AnimationState;
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Vector3 scale = transform.localScale;
        if (x >= 0)
        {
           
            // 右方向に移動中
            scale.x = 0.1f; // そのまま（右向き）
        }
        else
        {
       
            // 左方向に移動中
            scale.x = -0.1f; // 反転する（左向き）
        }
        

        // 代入し直す
        transform.localScale = scale;
        float y = Input.GetAxisRaw("Vertical");

        mesh.
        //変更　スピードをかけている
        
        transform.Translate(new Vector3(x, y, 0) * speed * Time.deltaTime);
        

    }
    private void PlayAnimation()
    {
        // アニメーション「testAnimationName」を再生
        spineAnimationState.SetAnimation(0, testAnimationName0, true);
    }
}