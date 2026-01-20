using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float tocDoXe = 100f;
    [SerializeField] private float lucReXe = 100f;
    [SerializeField] private float lucPhanh = 50f;
    [SerializeField] private GameObject hieuUngPhanh;

    private float dauVaoDiChuyen;
    private float dauVaoRe;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hieuUngPhanh.SetActive(false);   // ban đầu tắt
    }

    void Update()
    {
        dauVaoDiChuyen = Input.GetAxis("Vertical");
        dauVaoRe = Input.GetAxis("Horizontal");

        bool dangPhanh = dauVaoDiChuyen > 0 && Input.GetKey(KeyCode.Space);

        if (dangPhanh)
        {
            PhanhXe();
        }
        else
        {
            DiChuyenXe();
        }

        ReXe();

        // Bật/tắt hiệu ứng theo trạng thái phanh
        hieuUngPhanh.SetActive(dangPhanh);
    }

    void DiChuyenXe()
    {
        rb.AddRelativeForce(Vector3.forward * dauVaoDiChuyen * tocDoXe);
    }

    void ReXe()
    {
        Quaternion re = Quaternion.Euler(Vector3.up * dauVaoRe * lucReXe * Time.deltaTime);
        rb.MoveRotation(rb.rotation * re);
    }

    void PhanhXe()
    {
        rb.AddRelativeForce(Vector3.back * lucPhanh);
    }
}
