#include "StoreItem.h"

namespace CLI {
	StoreItem::StoreItem(int itemNumber)
		:ManagedObject(new ObjectTrackingDB::StoreItem(itemNumber))
	{
	}

	void StoreItem::auto_set_number()
	{
		m_Instance->setItemNumber();
	}
}

