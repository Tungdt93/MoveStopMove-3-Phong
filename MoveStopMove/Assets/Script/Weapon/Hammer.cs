using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : GameUnit
{
    public Rigidbody _rigidbody;
    private Character _owner;


    //public ParticleSystem hitVFX;

    public void OnInit(Character owner)
    {
        _rigidbody.velocity = Transform.forward * 10f;
        _owner = owner;
    }

    public void Update()
    {
        float travelRange = (_owner.transform.position - gameObject.transform.position).magnitude;
        if(travelRange >= _owner.attackRadius)
        {
            HammerPool.Despawn(this);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(Constant.TAG_CHARACTER))
        {
            //ParticlePool.Play(hitVFX, Transform.position, Quaternion.identity);
            HammerPool.Despawn(this);
            _owner.Hit();
        }
    }

}
