using Application.Services;

namespace Application.FacadePattern;

public interface IFacadeService
{
    public ILoginUserService LoginUserService { get; }
    public IRegisterUserService RegisterUserService { get; }
}

public class FacadeService : IFacadeService
{

    private ILoginUserService? _loginUserService;
    public ILoginUserService LoginUserService
    {
        get
        {
            return _loginUserService = _loginUserService ?? new LoginUserService();
        }
    }


    private IRegisterUserService? _registerUserService;
    public IRegisterUserService RegisterUserService
    {
        get
        {
            return _registerUserService = _registerUserService ?? new RegisterUserService();
        }
    }
}
