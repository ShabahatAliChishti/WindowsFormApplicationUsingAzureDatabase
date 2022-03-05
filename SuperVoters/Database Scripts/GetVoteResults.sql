IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'GetVoteResults')
BEGIN
    DROP PROCEDURE dbo.GetVoteResults
END

GO

--Test
/* 
exec dbo.GetVoteResults '03/03/22'
select * from dbo.CastVote
select * from dbo.TempCandidate
*/

CREATE PROCEDURE [dbo].[GetVoteResults]  
    @DateOfElection nvarchar(50)  
AS   
    SET NOCOUNT ON; 

    SELECT * INTO #temp from 
    (SELECT cv.CandidateId,  COUNT(*) as TotalVotes
    FROM SuperVoters.dbo.CastVote cv 
    JOIN SuperVoters.dbo.TempCandidate c on cv.CandidateId = c.CandidateId
     WHERE CAST(cv.DateInserted as date) = CAST(@DateOfElection as date)
    Group By cv.CandidateId) as abc

    SELECT c.CandidateName, t.TotalVotes from #Temp t
    JOIN dbo.TempCandidate c on c.CandidateId = t.CandidateId
 
GO
