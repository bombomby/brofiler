#pragma once
#include "Common.h"

namespace Profiler
{
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Returns current Thread Environment Block (Extremely fast approach to get Thread Unique ID)
BRO_INLINE const void* GetThreadUniqueID();
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
class SystemThread
{
public:
	SystemThread() : threadId(0) {}

	bool Create( DWORD WINAPI Action( LPVOID lpParam ), LPVOID lpParam );
	void Terminate();

	operator bool() { return threadId != 0; }
private:
	uint64 threadId;
};

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
void ThreadSleep(DWORD milliseconds);
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
BRO_INLINE void AtomicIncrement(volatile uint* value);
BRO_INLINE void AtomicDecrement(volatile uint* value);


}