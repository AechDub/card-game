using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler  {

    //public Draggable.Slot typeOfItem = Draggable.Slot.DEBUNK;
    public void OnDrop(PointerEventData eventData)
    {
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.returnParent = this.transform;
            //if (typeOfItem == d.typeOfItem || typeOfItem == Draggable.Slot.INVENTORY)
            //{
            //    d.returnParent = this.transform;
            //}
        }
    }

}
