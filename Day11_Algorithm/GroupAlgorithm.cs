using System;
using System.Linq;

namespace N_GroupAlgorithm
{
    internal class GroupAlgorithmClass
    {
        class Record
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
        }
        static public void GroupAlgorithm()
        {
            //테스트용 데이터 채우기 로컬 함수
            List<Record> GetAll()
            {
                return new List<Record>
                {
                    new Record { Name = "name_1", Quantity = 1},
                    new Record { Name = "name_2", Quantity = 3},
                    new Record { Name = "name_3", Quantity = 5},
                    new Record { Name = "name_4", Quantity = 7}
                };
            }

            //컬렉션 데이터 출력용 로컬 함수
            void PrintData(string message, List<Record> data)
            {
                Console.WriteLine(message);
                foreach (var item in data)
                {
                    Console.WriteLine($"{item.Name,5} - {item.Quantity}");
                }
            }
            //01. 입력
            List<Record> records = GetAll(); //입력 데이터
            List<Record> groups = new List<Record>(); //출력 데이터
            int N = records.Count; //의사 코드

            //02. 처리 : Group 알고리즘(SORT -> SUM -> GROUP)
            //그룹 정렬 : SORT
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (String.Compare(records[i].Name, records[j].Name) > 0)
                    {
                        var t = records[i]; records[i] = records[j]; records[j] = t;
                    }
                }
            }

            //그룹 소계: GROUP
            int subtotal = 0;
            for (int i = 0; i < N; i++)
            {
                subtotal += records[i].Quantity;
                if ((i + 1) == N || (records[i].Name != records[i + 1].Name))
                {
                    groups.Add(new Record
                    {
                        Name = records[i].Name,
                        Quantity = subtotal
                    });
                    subtotal = 0;
                }
            }
            //03. 출력
            PrintData("[1] 정렬된 원본 데이터 : ", records);
            PrintData("[2] 이름으로 그룹화된 데이터 : ", groups);
            PrintData("[3] LINQ로 그룹화된 데이터 : ", records.GroupBy(r => r.Name).Select(g => new Record
            {
                Name = g.Key,
                Quantity = g.Sum(n => n.Quantity)
            }).ToList());
        }
        
    }
}
