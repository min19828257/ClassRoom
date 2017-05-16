﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    class Common
    {
        public const int START_PID  = 1000;
        public const int JOB        = 1;

        #region begin follow section
        /* pid 순 정렬, 차트용 */
        private static int Follow_Default(ProcessData A, ProcessData B)
        {
            if (Convert.ToInt32(A.pid) < Convert.ToInt32(B.pid))
                return -1;
            return 1;
        }

        /* 도착 시간 정렬 */
        private static int Follow_Initialize(ProcessData A, ProcessData B)
        {
            if (Convert.ToInt32(A.arrived_time) < Convert.ToInt32(B.arrived_time))
                return -1;
            return 1;
        }

        /* 서비스 시간 정렬 */
        private static int Follow_SRT(ProcessData A, ProcessData B)
        {
            if (Convert.ToInt32(A.service_time) < Convert.ToInt32(B.service_time))
                return -1;
            if ((Convert.ToInt32(A.service_time) == Convert.ToInt32(B.service_time)) &&
                (Convert.ToInt32(A.pid) < Convert.ToInt32(B.pid)))
                return -1;
            return 1;
        }

        private static int Follow_Priority(ProcessData A, ProcessData B)
        {
            if (Convert.ToInt32(A.pid) < Convert.ToInt32(B.pid))
                return -1;
            return 1;
        }

        private static int Follow_RoundRobin(ProcessData A, ProcessData B)
        {
            if (Convert.ToInt32(A.pid) < Convert.ToInt32(B.pid))
                return -1;
            return 1;
        }
        #endregion

        #region begin sort section
        public static List<ProcessData> Sort_Default(List<ProcessData> data)
        {
            data.Sort(Follow_Default);
            return data;
        }

        public static List<ProcessData> Sort_Initialize(List<ProcessData> data)
        {
            data.Sort(Follow_Initialize);
            return data;
        }

        public static List<ProcessData> Sort_SRT(List<ProcessData> data)
        {
            data.Sort(Follow_SRT);
            return data;
        }

        public static List<ProcessData> Sort_Priority(List<ProcessData> data)
        {
            data.Sort(Follow_Priority);
            return data;
        }

        public static List<ProcessData> Sort_RoundRobin(List<ProcessData> data)
        {
            data.Sort(Follow_RoundRobin);
            return data;
        }
        #endregion
    }
}