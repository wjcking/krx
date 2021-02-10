
delegate void Action();
delegate void Action<T, T1>(T t, T1 t1);
delegate void Action<T, T1, T2>(T t, T1 t1, T2 t2);
delegate void Action<T, T1, T2, T3>(T t, T1 t1, T2 t2, T3 t3);

delegate T Func<T>();
delegate T1 Func<T, T1>(T arg1);
delegate T2 Func<T, T1, T2>(T arg1, T1 arg2);
delegate T3 Func<T, T1, T2, T3>(T arg1, T1 arg2, T2 arg3);

