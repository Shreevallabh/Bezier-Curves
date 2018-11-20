using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    // Rotating gameObject in random fashion in all 3 axis
    private IEnumerator Start()
    {
        while(Application.isPlaying)
        {
            Quaternion rotation = Random.rotation;

            while(Vector3.Distance (this.transform.root.eulerAngles, rotation.eulerAngles)>1.0f)
            {
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, rotation, Time.deltaTime);

                yield return null;
            }

            yield return new WaitForSeconds(1.0f);
        }

    }
}
