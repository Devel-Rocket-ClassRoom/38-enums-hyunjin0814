using System;

// README.md를 읽고 아래에 코드를 작성하세요.
CharacterState state = CharacterState.Idle;
Array array = Enum.GetValues(typeof(CharacterState));
bool exit = false;

Console.WriteLine("=== 캐릭터 상태 관리 ===");


while (!exit)
{
    PrintState();
    Console.WriteLine("1. 상태 변경");
    Console.WriteLine("2. 상태 목록 보기");
    Console.WriteLine("3. 현재 행동 보기");
    Console.WriteLine("4. 종료");
    Console.Write("선택: ");
    int input = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (input)
    {
        case 1:
            ChangeState();
            break;
        case 2:
            PrintList();
            break;
        case 3:
            NowAction();
            break;
        case 4:
            exit = true;
            break;
    }
    
}

Console.WriteLine("프로그램을 종료합니다.");

void PrintState()
{
    Console.WriteLine($"현재 상태: {state}");
    Console.WriteLine();
}

void PrintList()
{
    Console.WriteLine("=== 상태 목록 ===");
    
    foreach (CharacterState s in array)
    {
        Console.WriteLine($"{s} = {(int)s}");
    }
    Console.WriteLine();
}

void ChangeState()
{
    Console.Write($"변경할 상태 번호 입력 (0-{array.Length - 1}): ");
    string changeInput = Console.ReadLine();

    if (int.TryParse(changeInput, out int result))
    {
        if (result < 0 || result >= array.Length)
        {
            Console.WriteLine("범위에 맞는 숫자를 입력해주세요.");
        }
        else
        {
            state = (CharacterState)result;
            Console.WriteLine($"상태가 {state}(으)로 변경되었습니다.");
        }
    }
    else
    {
        Console.WriteLine($"{changeInput}은 정수가 아닙니다. 정수를 입력해 주세요.");
    }
    Console.WriteLine();
}

void NowAction()
{
    switch (state)
    {
        case CharacterState.Idle:
            Console.WriteLine("[행동] 대기 상태입니다.");
            break;
        case CharacterState.Walking:
            Console.WriteLine("[행동] 걷기 상태입니다.");
            break;
        case CharacterState.Running:
            Console.WriteLine("[행동] 뛰기 상태입니다.");
            break;
        case CharacterState.Jumping:
            Console.WriteLine("[행동] 점프 상태입니다.");
            break;
        case CharacterState.Attacking:
            Console.WriteLine("[행동] 적을 공격합니다!");
            break;
        case CharacterState.Dead:
            Console.WriteLine("[행동] 사망 상태입니다. 행동할 수 없습니다.");
            break;
    }
    Console.WriteLine();
}

enum CharacterState
{
    Idle,
    Walking,
    Running,
    Jumping,
    Attacking,
    Dead
}