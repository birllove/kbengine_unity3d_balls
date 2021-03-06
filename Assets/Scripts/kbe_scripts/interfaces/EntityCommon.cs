namespace KBEngine
{
  	using UnityEngine; 
	using System; 
	using System.Collections; 
	using System.Collections.Generic;
	
    public class EntityCommon : if_Entity_error_use______git_submodule_update_____kbengine_plugins_______open_this_file_and_I_will_tell_you 
    {
		public EntityCommon()
		{
		}

		/*
			以下函数是实体的属性被设置时插件底层调用
			set_属性名称(), 想监听哪个属性就实现该函数，事件触发后由于world.cs中监听了该事件，world.cs会取出数据做行为表现。
			另外，这些属性如果需要同步到客户端，前提是在def中定义过该属性，并且属性的广播标志为ALL_CLIENTS、OTHER_CLIENTS、等等，
			参考：http://www.kbengine.org/cn/docs/programming/entitydef.html
		*/		
		public virtual void set_modelID(object old)
		{
			object v = getDefinedProperty("modelID");
//			Dbg.DEBUG_MSG(className + "::set_modelID: " + old + " => " + v); 
			Event.fireOut("set_modelID", new object[]{this, v});
		}
    }
    
} 
