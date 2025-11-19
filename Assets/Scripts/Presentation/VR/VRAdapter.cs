using Assets.Scripts.Domain.VR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Assets.Scripts.Presentation.VR
{
    internal class VRAdapter : MonoBehaviour, IVRAdapter
    {
        [SerializeField] private Transform _transform;

        private ReactiveProperty<System.Numerics.Vector3> _position = new();
        public IReadOnlyReactiveProperty<System.Numerics.Vector3> Position => _position;

        private void Start()
        {
            this.UpdateAsObservable()
                .Select(_ => _transform != null ? _transform.position : UnityEngine.Vector3.zero)
                .Select(p => new System.Numerics.Vector3(p.x, p.y, p.z))
                .DistinctUntilChanged()
                .Subscribe(p => _position.Value = p)
                .AddTo(this);
        }
    }
}
